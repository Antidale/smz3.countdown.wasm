using System.Net.Http.Json;
using FeInfo.Common.DTOs;
using smz3.countdown.wasm.Models;

namespace smz3.countdown.wasm.Services;

public interface IFeApiDataService
{
    Task<SeedDetail?> GetSeedByIdAsync(int id);
    Task<string> GetSeedHtmlAsync(int id);
    Task<List<SeedDetail>> GetSeedsAsync(string binaryFlags = "", string flagName = "", string seedValue = "");
    Task<List<TournamentSummary>> GetTournamentsAsync();
    Task<List<TournamentRegistrant>> GetTournamentRegistrantsAsync(int id);
}

public class FeApiDataService(FeApiHttpClient httpClient) : IFeApiDataService
{
    public async Task<List<TournamentSummary>> GetTournamentsAsync()
    {
        return await httpClient.GetFromJsonAsync<List<TournamentSummary>>("Tournament") ?? [];
    }

    public async Task<string> GetSeedHtmlAsync(int id)
    {
        return await httpClient.GetStringAsync($"seed/{id}/html");
    }

    public async Task<List<SeedDetail>> GetSeedsAsync(string binaryFlags = "", string flagName = "", string seedValue = "")
    {
        return await httpClient.GetFromJsonAsync<List<SeedDetail>>("seed") ?? [];
    }

    public async Task<SeedDetail?> GetSeedByIdAsync(int id)
    {
        return await httpClient.GetFromJsonAsync<SeedDetail>($"seed/{id}");
    }

    public async Task<List<TournamentRegistrant>> GetTournamentRegistrantsAsync(int id)
    {
        return await httpClient.GetFromJsonAsync<List<TournamentRegistrant>>($"Tournament/{id}/registrants") ?? [];
    }
}

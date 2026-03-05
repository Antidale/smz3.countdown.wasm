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
        try
        {
            return await httpClient.GetFromJsonAsync<List<TournamentSummary>>("Tournament") ?? [];
        }
        catch
        {
            return [];
        }
    }

    public async Task<string> GetSeedHtmlAsync(int id)
    {
        try
        {
            return await httpClient.GetStringAsync($"seed/{id}/html");
        }
        catch
        {
            return string.Empty;
        }

    }

    public async Task<List<SeedDetail>> GetSeedsAsync(string binaryFlags = "", string flagName = "", string seedValue = "")
    {
        try
        {
            return await httpClient.GetFromJsonAsync<List<SeedDetail>>("seed") ?? [];
        }
        catch
        {
            return [];
        }

    }

    public async Task<SeedDetail?> GetSeedByIdAsync(int id)
    {
        try
        {
            return await httpClient.GetFromJsonAsync<SeedDetail>($"seed/{id}");
        }
        catch
        {
            return default;
        }

    }

    public async Task<List<TournamentRegistrant>> GetTournamentRegistrantsAsync(int id)
    {
        try
        {
            return await httpClient.GetFromJsonAsync<List<TournamentRegistrant>>($"Tournament/{id}/registrants") ?? [];
        }
        catch
        {
            return [];
        }
    }
}

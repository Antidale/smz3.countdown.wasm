using System.Net.Http.Json;
using System.Web;
using FeInfo.Common.DTOs;
using smz3.countdown.wasm.Constants;
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

public class FeApiDataService(HttpClient httpClient) : IFeApiDataService
{
    public async Task<List<TournamentSummary>> GetTournamentsAsync()
    {
        try
        {
            return await httpClient.GetFromJsonAsync<List<TournamentSummary>>($"{EndpointConstants.API_BASE_ADDRESS}/Tournament") ?? [];
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
            return await httpClient.GetStringAsync($"{EndpointConstants.API_BASE_ADDRESS}/seed/{id}/html");
        }
        catch (Exception ex)
        {
            var stuff = ex;
            return string.Empty;
        }

    }

    public async Task<List<SeedDetail>> GetSeedsAsync(string binaryFlags = "", string flagName = "", string seedValue = "")
    {
        try
        {
            var builder = new UriBuilder($"{EndpointConstants.API_BASE_ADDRESS}/seed");
            var query = HttpUtility.ParseQueryString(builder.Query);
            query["seedString"] = seedValue;
            query["binaryFlags"] = binaryFlags;
            query["flagSearch"] = flagName;
            builder.Query = query.ToString();
            var stuff = builder.ToString();
            return await httpClient.GetFromJsonAsync<List<SeedDetail>>(stuff) ?? [];
        }
        catch (Exception ex)
        {
            var junk = ex.ToString();
            return [];
        }

    }

    public async Task<SeedDetail?> GetSeedByIdAsync(int id)
    {
        try
        {
            return await httpClient.GetFromJsonAsync<SeedDetail>($"{EndpointConstants.API_BASE_ADDRESS}/seed/{id}");
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
            return await httpClient.GetFromJsonAsync<List<TournamentRegistrant>>($"{EndpointConstants.API_BASE_ADDRESS}/Tournament/{id}/registrants") ?? [];
        }
        catch
        {
            return [];
        }
    }
}

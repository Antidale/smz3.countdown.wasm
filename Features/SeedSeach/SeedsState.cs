using smz3.countdown.wasm.Models;
using smz3.countdown.wasm.Services;

namespace smz3.countdown.wasm.Features.SeedSeach;

public class SeedsState(IFeApiDataService dataService)
{
    public HashSet<SeedDetail> Seeds { get; private set; } = [];
    private Dictionary<int, string> _seedHtml { get; set; } = [];

    public async Task GetSeeds(string binaryFlags = "", string flagName = "", string seedValue = "")
    {
        var seeds = await dataService.GetSeedsAsync(binaryFlags: binaryFlags, flagName: flagName, seedValue: seedValue);
        foreach (var seed in seeds)
        {
            Seeds.Add(seed);
        }
    }
}

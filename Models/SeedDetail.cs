namespace smz3.countdown.wasm.Models;

public record SeedDetail(
    int SeedId,
    string Flagset,
    string Verification,
    string SourceUrl,
    string Seed,
    string Version,
    float Rank
)
{

}

namespace smz3.countdown.wasm.Models
{
    public class SpoilerResponse
    {
        public Seed Seed { get; set; } = new Seed();
        public List<SpoilerLocation> Locations { get; set; } = new List<SpoilerLocation>();

    }
}

namespace smz3.countdown.wasm.Features.StartingItems
{
    public class GenerateRequest
    {
        public string GameMode { get; set; } = "Normal";
        public string Z3Logic { get; set; } = "Normal";
        public string SMLogic { get; set; } = "Normal";
        public string SwordLocation { get; set; } = "Randomized";
        public string MorphLocation { get; set; } = "Normal";
        public string Goal { get; set; } = "fastganondefeatmotherbrain";
        public string KeyShuffle { get; set; } = "None";
        public bool Race { get; set; } = false;
        public string OpenTower { get; set; } = "SevenCrystals";
        public string GanonVulnerable { get; set; } = "SevenCrystals";
        public string OpenTourian { get; set; } = "FourBosses";
        public string InitialItems { get; set; } = "Boots";
    }
}

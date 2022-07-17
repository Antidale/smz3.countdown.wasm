namespace smz3.countdown.wasm.Attributes
{
    public class AreaAttribute : Attribute
    {
        public string DisplayText;
        public string LocationArea;
        public string LocationRegion;

        public AreaAttribute(string displayText, string locationArea, string locationRegion)
        {
            DisplayText = displayText;
            LocationArea = locationArea;
            LocationRegion = locationRegion;
        }

        public AreaAttribute()
        {
            DisplayText = "";
            LocationArea = "";
            LocationRegion = "";
        }
    }
}

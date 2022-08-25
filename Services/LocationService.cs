namespace smz3.countdown.wasm.Services
{
    public class LocationService
    {
        public Dictionary<string, List<string>> Locations { get; set; } = new Dictionary<string, List<string>>();
        public Dictionary<string, List<string>> AltLocations { get; set; } = new Dictionary<string, List<string>>();

        public LocationService()
        {
            Locations = new Dictionary<string, List<string>>
            {
                ["Light World"] = new List<string>
                {
                    "Light World North West",
                    "Light World North East",
                    "Light World South"
                },
                ["Hyrule Castle"] = new List<string>
                {
                    "Hyrule Castle"
                },
                ["Castle Tower"] = new List<string>
                {
                    "Castle Tower"
                },
                ["Eastern Palace"] = new List<string>
                {
                    "Eastern Palace"
                },
                ["Desert Palace"] = new List<string>
                {
                    "Desert Palace"
                },
                ["Tower of Hera"] = new List<string>
                {
                    "Tower of Hera"
                },
                ["Death Mountain"] = new List<string>
                {
                    "Light World Death Mountain West",
                    "Light World Death Mountain East",
                },
                ["Dark World"] = new List<string>
                {
                    "Dark World Death Mountain West",
                    "Dark World Death Mountain East",
                    "Dark World North West",
                    "Dark World North East",
                    "Dark World South",
                    "Dark World Mire"
                },
                ["Palace of Darkness"] = new List<string>
                {
                    "Palace of Darkness"
                },
                ["Swamp Palace"] = new List<string>
                {
                    "Swamp Palace"
                },
                ["Skull Woods"] = new List<string>
                {
                    "Skull Woods"
                },
                ["Thieves' Town"] = new List<string>
                {
                    "Thieves' Town"
                },
                ["Ice Palace"] = new List<string>
                {
                    "Ice Palace"
                },
                ["Misery Mire"] = new List<string>
                {
                    "Misery Mire"
                },
                ["Turtle Rock"] = new List<string>
                {
                    "Turtle Rock"
                },
                ["Ganon's Tower"] = new List<string>
                {
                    "Ganon's Tower"
                },
                ["Crateria"] = new List<string>
                {
                    "Crateria West",
                    "Crateria Central",
                    "Crateria East"
                },
                ["Brinstar"] = new List<string>
                {
                    "Brinstar Blue",
                    "Brinstar Green",
                    "Brinstar Pink",
                    "Brinstar Red",
                    "Brinstar Kraid",
                },
                ["Wrecked Ship"] = new List<string>
                {
                    "Wrecked Ship"
                },
                ["Maridia"] = new List<string>
                {
                    "Maridia Outer",
                    "Maridia Inner"
                },
                ["Upper Norfair"] = new List<string>
                {
                    "Norfair Upper West",
                    "Norfair Upper East",
                    "Norfair Upper Crocomire"
                },
                ["Lower Norfair"] = new List<string>
                {
                    "Norfair Lower West",
                    "Norfair Lower East"
                }
            };

            AltLocations = new Dictionary<string, List<string>>
            {
                ["West LW"] = new List<string>
                {
                    "Light World North West",
                    "Castle Tower",
                    "Hyrule Castle",
                    "Maze Race",
                    "Library",
                    "Flute Spot",
                    "South of Grove",
                    "Link's House",
                    "Sunken Treasure",
                    "Floodgate Chest",
                },
                ["East LW"] = new List<string>
                {
                    "Eastern Palace",
                    "Light World North East",
                    "Mini Moldorm Cave - Far Left",
                    "Mini Moldorm Cave - Left",
                    "Mini Moldorm Cave - NPC",
                    "Mini Moldorm Cave - Right",
                    "Mini Moldorm Cave - Far Right",
                    "Lake Hylia Island",
                    "Ice Rod Cave",
                    "Hobo"
                },
                ["Desert"] = new List<string>
                {
                    "Desert Palace",
                    "Bombos Tablet",
                    "Desert Ledge",
                    "Aginah's Cave",
                    "Checkerboard Cave",
                },
                ["Death Mountain"] = new List<string>
                {
                    "Light World Death Mountain West",
                    "Light World Death Mountain East",
                    "Tower of Hera"
                },
                ["East DW"] = new List<string>
                {
                    "Palace of Darkness",
                    "Dark World North East"
                },
                ["Village of Outcasts"] = new List<string>
                {
                    "Thieves' Town",
                    "Dark World North West",
                    "Skull Woods",
                    "Stumpy",
                    "Digging Game"
                },
                ["Dark Swamp"] = new List<string>
                {
                    "Swamp Palace",
                    "Ice Palace",
                    "Hype Cave - Top",
                    "Hype Cave - Middle Right",
                    "Hype Cave - Middle Left",
                    "Hype Cave - Bottom",
                    "Hype Cave - NPC"
                },
                ["Misery Mire"] = new List<string>
                {
                    "Dark World Mire",
                    "Misery Mire"
                },
                ["Dark DM"] = new List<string>
                {
                    "Dark World Death Mountain West",
                    "Dark World Death Mountain East",
                    "Turtle Rock"
                },
                ["Ganon's Tower"] = new List<string>
                {
                    "Ganon's Tower",
                },
                ["Crateria"] = new List<string>
                {
                    "Crateria West",
                    "Crateria Central",
                    "Brinstar Blue",
                    "Missile (Crateria moat)"
                },
                ["Green/Pink Brin"] = new List<string>
                {
                    "Brinstar Green",
                    "Brinstar Pink"
                },
                ["Red Brin/Kraid"] = new List<string>
                {
                    "Brinstar Red",
                    "Brinstar Kraid"
                },
                ["Wrecked Ship"] = new List<string>
                {
                    "Crateria East",
                    "Wrecked Ship"
                },
                ["West Maridia"] = new List<string>
                {
                    "Maridia Outer",
                    "Super Missile (yellow Maridia)",
                    "Missile (yellow Maridia super missile)",
                    "Missile (yellow Maridia false wall)"
                },
                ["East Maridia"] = new List<string>
                {
                    "Plasma Beam",
                    "Missile (left Maridia sand pit room)",
                    "Reserve Tank, Maridia",
                    "Missile (right Maridia sand pit room)",
                    "Power Bomb (right Maridia sand pit room)",
                    "Missile (pink Maridia)",
                    "Super Missile (pink Maridia)",
                    "Missile (Draygon)",
                    "Energy Tank, Botwoon",
                    "Space Jump",
                },
                ["Upper Norfair"] = new List<string>
                {
                    "Norfair Upper West",
                    "Norfair Upper East",
                    "Missile (above Crocomire)"
                },
                ["Crocomire"] = new List<string>
                {
                    "Norfair Upper Crocomire"
                },
                ["Lower Norfair"] = new List<string>
                {
                    "Norfair Lower West",
                    "Norfair Lower East"
                }
            };
        }
    }
}

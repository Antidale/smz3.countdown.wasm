namespace smz3.countdown.wasm.Services
{
    public class LocationService
    {
        public Dictionary<string, List<string>> Locations { get; set; } = [];
        public Dictionary<string, List<string>> AltLocations { get; set; } = [];

        public LocationService()
        {
            Locations = new Dictionary<string, List<string>>
            {
                ["Light World"] =
                [
                    "Light World North West",
                    "Light World North East",
                    "Light World South"
                ],
                ["Hyrule Castle"] =
                [
                    "Hyrule Castle"
                ],
                ["Castle Tower"] =
                [
                    "Castle Tower"
                ],
                ["Eastern Palace"] =
                [
                    "Eastern Palace"
                ],
                ["Desert Palace"] =
                [
                    "Desert Palace"
                ],
                ["Tower of Hera"] =
                [
                    "Tower of Hera"
                ],
                ["Death Mountain"] =
                [
                    "Light World Death Mountain West",
                    "Light World Death Mountain East",
                ],
                ["Dark World"] =
                [
                    "Dark World Death Mountain West",
                    "Dark World Death Mountain East",
                    "Dark World North West",
                    "Dark World North East",
                    "Dark World South",
                    "Dark World Mire"
                ],
                ["Palace of Darkness"] =
                [
                    "Palace of Darkness"
                ],
                ["Swamp Palace"] =
                [
                    "Swamp Palace"
                ],
                ["Skull Woods"] =
                [
                    "Skull Woods"
                ],
                ["Thieves' Town"] =
                [
                    "Thieves' Town"
                ],
                ["Ice Palace"] =
                [
                    "Ice Palace"
                ],
                ["Misery Mire"] =
                [
                    "Misery Mire"
                ],
                ["Turtle Rock"] =
                [
                    "Turtle Rock"
                ],
                ["Ganon's Tower"] =
                [
                    "Ganon's Tower"
                ],
                ["Crateria"] =
                [
                    "Crateria West",
                    "Crateria Central",
                    "Crateria East"
                ],
                ["Brinstar"] =
                [
                    "Brinstar Blue",
                    "Brinstar Green",
                    "Brinstar Pink",
                    "Brinstar Red",
                    "Brinstar Kraid",
                ],
                ["Wrecked Ship"] =
                [
                    "Wrecked Ship"
                ],
                ["Maridia"] =
                [
                    "Maridia Outer",
                    "Maridia Inner"
                ],
                ["Upper Norfair"] =
                [
                    "Norfair Upper West",
                    "Norfair Upper East",
                    "Norfair Upper Crocomire"
                ],
                ["Lower Norfair"] =
                [
                    "Norfair Lower West",
                    "Norfair Lower East"
                ]
            };

            AltLocations = new Dictionary<string, List<string>>
            {
                ["West LW"] =
                [
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
                ],
                ["East LW"] =
                [
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
                ],
                ["Desert"] =
                [
                    "Desert Palace",
                    "Bombos Tablet",
                    "Desert Ledge",
                    "Aginah's Cave",
                    "Checkerboard Cave",
                ],
                ["Death Mountain"] =
                [
                    "Light World Death Mountain West",
                    "Light World Death Mountain East",
                    "Tower of Hera"
                ],
                ["East DW"] =
                [
                    "Palace of Darkness",
                    "Dark World North East"
                ],
                ["Village of Outcasts"] =
                [
                    "Thieves' Town",
                    "Dark World North West",
                    "Skull Woods",
                    "Stumpy",
                    "Digging Game"
                ],
                ["Dark Swamp"] =
                [
                    "Swamp Palace",
                    "Ice Palace",
                    "Hype Cave - Top",
                    "Hype Cave - Middle Right",
                    "Hype Cave - Middle Left",
                    "Hype Cave - Bottom",
                    "Hype Cave - NPC"
                ],
                ["Misery Mire"] =
                [
                    "Dark World Mire",
                    "Misery Mire"
                ],
                ["Dark DM"] =
                [
                    "Dark World Death Mountain West",
                    "Dark World Death Mountain East",
                    "Turtle Rock"
                ],
                ["Ganon's Tower"] =
                [
                    "Ganon's Tower",
                ],
                ["Crateria"] =
                [
                    "Crateria West",
                    "Crateria Central",
                    "Brinstar Blue",
                    "Missile (Crateria moat)"
                ],
                ["Green/Pink Brin"] =
                [
                    "Brinstar Green",
                    "Brinstar Pink"
                ],
                ["Red Brin/Kraid"] =
                [
                    "Brinstar Red",
                    "Brinstar Kraid"
                ],
                ["Wrecked Ship"] =
                [
                    "Crateria East",
                    "Wrecked Ship"
                ],
                ["West Maridia"] =
                [
                    "Maridia Outer",
                    "Super Missile (yellow Maridia)",
                    "Missile (yellow Maridia super missile)",
                    "Missile (yellow Maridia false wall)"
                ],
                ["East Maridia"] =
                [
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
                ],
                ["Upper Norfair"] =
                [
                    "Norfair Upper West",
                    "Norfair Upper East",
                    "Missile (above Crocomire)"
                ],
                ["Crocomire"] =
                [
                    "Norfair Upper Crocomire"
                ],
                ["Lower Norfair"] =
                [
                    "Norfair Lower West",
                    "Norfair Lower East"
                ]
            };
        }
    }
}

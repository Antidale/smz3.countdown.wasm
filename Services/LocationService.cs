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
                    "Aginah's Cave",
                    "Blind's Hideout - Top",
                    "Blind's Hideout - Far Left",
                    "Blind's Hideout - Left",
                    "Blind's Hideout - Right",
                    "Blind's Hideout - Far Right",
                    "Bombos Tablet",
                    "Bottle Merchant",
                    "Checkerboard Cave",
                    "Chicken House",
                    "Desert Ledge",
                    "Graveyard Ledge",
                    "Hobo",
                    "Ice Rod Cave",
                    "Floodgate Chest",
                    "Flute Spot",
                    "Kakariko Tavern",
                    "Kakariko Well - Top",
                    "Kakariko Well - Left",
                    "Kakariko Well - Middle",
                    "Kakariko Well - Right",
                    "Kakariko Well - Bottom",
                    "King's Tomb",
                    "King Zora",
                    "Lake Hylia Island",
                    "Library",
                    "Link's House",
                    "Lost Woods Hideout",
                    "Lumberjack Tree",
                    "Magic Bat",
                    "Master Sword Pedestal",
                    "Maze Race",
                    "Mini Moldorm Cave - Far Left",
                    "Mini Moldorm Cave - Left",
                    "Mini Moldorm Cave - NPC",
                    "Mini Moldorm Cave - Right",
                    "Mini Moldorm Cave - Far Right",
                    "Mushroom",
                    "Pegasus Rocks",
                    "Potion Shop",
                    "Sahasrahla",
                    "Sahasrahla's Hut - Left",
                    "Sahasrahla's Hut - Middle",
                    "Sahasrahla's Hut - Right",
                    "Sick Kid",
                    "South of Grove",
                    "Sunken Treasure",
                    "Waterfall Fairy - Right",
                    "Waterfall Fairy - Left",
                    "Zora's Ledge"
                },
                ["Hyrule Castle"] = new List<string>
                {
                    "Hyrule Castle - Boomerang Chest",
                    "Hyrule Castle - Map Chest",
                    "Hyrule Castle - Zelda's Cell",
                    "Link's Uncle",
                    "Sanctuary",
                    "Secret Passage",
                    "Sewers - Secret Room - Left",
                    "Sewers - Secret Room - Middle",
                    "Sewers - Secret Room - Right",
                    "Sewers - Dark Cross"
                },
                ["Castle Tower"] = new List<string>
                {
                    "Castle Tower - Foyer",
                    "Castle Tower - Dark Maze"
                },
                ["Eastern Palace"] = new List<string>
                {
                    "Eastern Palace - Cannonball Chest",
                    "Eastern Palace - Map Chest",
                    "Eastern Palace - Compass Chest",
                    "Eastern Palace - Big Chest",
                    "Eastern Palace - Big Key Chest",
                    "Eastern Palace - Armos Knights",
                },
                ["Desert Palace"] = new List<string>
                {
                    "Desert Palace - Big Chest",
                    "Desert Palace - Torch",
                    "Desert Palace - Map Chest",
                    "Desert Palace - Big Key Chest",
                    "Desert Palace - Compass Chest",
                    "Desert Palace - Lanmolas",
                },
                ["Tower of Hera"] = new List<string>
                {
                    "Tower of Hera - Basement Cage",
                    "Tower of Hera - Map Chest",
                    "Tower of Hera - Big Key Chest",
                    "Tower of Hera - Compass Chest",
                    "Tower of Hera - Big Chest",
                    "Tower of Hera - Moldorm",
                },
                ["Death Mountain"] = new List<string>
                {
                    "Ether Tablet",
                    "Floating Island",
                    "Mimic Cave",
                    "Old Man",
                    "Paradox Cave Upper - Left",
                    "Paradox Cave Upper - Right",
                    "Paradox Cave Lower - Far Left",
                    "Paradox Cave Lower - Left",
                    "Paradox Cave Lower - Middle",
                    "Paradox Cave Lower - Right",
                    "Paradox Cave Lower - Far Right",
                    "Spectacle Rock",
                    "Spectacle Rock Cave",
                    "Spiral Cave",
                },
                ["Dark World"] = new List<string>
                {
                    "Spike Cave",
                    "Hookshot Cave - Top Right",
                    "Hookshot Cave - Top Left",
                    "Hookshot Cave - Bottom Left",
                    "Hookshot Cave - Bottom Right",
                    "Superbunny Cave - Top",
                    "Superbunny Cave - Bottom",
                    "Bumper Cave",
                    "Chest Game",
                    "C-Shaped House",
                    "Brewery",
                    "Hammer Pegs",
                    "Blacksmith",
                    "Purple Chest",
                    "Catfish",
                    "Pyramid",
                    "Pyramid Fairy - Left",
                    "Pyramid Fairy - Right",
                    "Digging Game",
                    "Stumpy",
                    "Hype Cave - Top",
                    "Hype Cave - Middle Right",
                    "Hype Cave - Middle Left",
                    "Hype Cave - Bottom",
                    "Hype Cave - NPC",
                    "Mire Shed - Left",
                    "Mire Shed - Right",
                },
                ["Palace of Darkness"] = new List<string>
                {
                    "Palace of Darkness - Shooter Room",
                    "Palace of Darkness - Big Key Chest",
                    "Palace of Darkness - Stalfos Basement",
                    "Palace of Darkness - The Arena - Bridge",
                    "Palace of Darkness - The Arena - Ledge",
                    "Palace of Darkness - Map Chest",
                    "Palace of Darkness - Compass Chest",
                    "Palace of Darkness - Harmless Hellway",
                    "Palace of Darkness - Dark Basement - Left",
                    "Palace of Darkness - Dark Basement - Right",
                    "Palace of Darkness - Dark Maze - Top",
                    "Palace of Darkness - Dark Maze - Bottom",
                    "Palace of Darkness - Big Chest",
                    "Palace of Darkness - Helmasaur King",
                },
                ["Swamp Palace"] = new List<string>
                {
                    "Swamp Palace - Entrance",
                    "Swamp Palace - Map Chest",
                    "Swamp Palace - Big Chest",
                    "Swamp Palace - Compass Chest",
                    "Swamp Palace - West Chest",
                    "Swamp Palace - Big Key Chest",
                    "Swamp Palace - Flooded Room - Left",
                    "Swamp Palace - Flooded Room - Right",
                    "Swamp Palace - Waterfall Room",
                    "Swamp Palace - Arrghus",
                },
                ["Skull Woods"] = new List<string>
                {
                    "Skull Woods - Pot Prison",
                    "Skull Woods - Compass Chest",
                    "Skull Woods - Big Chest",
                    "Skull Woods - Map Chest",
                    "Skull Woods - Pinball Room",
                    "Skull Woods - Big Key Chest",
                    "Skull Woods - Bridge Room",
                    "Skull Woods - Mothula",
                },
                ["Thieves' Town"] = new List<string>
                {
                    "Thieves' Town - Map Chest",
                    "Thieves' Town - Ambush Chest",
                    "Thieves' Town - Compass Chest",
                    "Thieves' Town - Big Key Chest",
                    "Thieves' Town - Attic",
                    "Thieves' Town - Blind's Cell",
                    "Thieves' Town - Big Chest",
                    "Thieves' Town - Blind",
                },
                ["Ice Palace"] = new List<string>
                {
                    "Ice Palace - Compass Chest",
                    "Ice Palace - Spike Room",
                    "Ice Palace - Map Chest",
                    "Ice Palace - Big Key Chest",
                    "Ice Palace - Iced T Room",
                    "Ice Palace - Freezor Chest",
                    "Ice Palace - Big Chest",
                    "Ice Palace - Kholdstare",
                },
                ["Misery Mire"] = new List<string>
                {
                    "Misery Mire - Main Lobby",
                    "Misery Mire - Map Chest",
                    "Misery Mire - Bridge Chest",
                    "Misery Mire - Spike Chest",
                    "Misery Mire - Compass Chest",
                    "Misery Mire - Big Key Chest",
                    "Misery Mire - Big Chest",
                    "Misery Mire - Vitreous",
                },
                ["Turtle Rock"] = new List<string>
                {
                    "Turtle Rock - Compass Chest",
                    "Turtle Rock - Roller Room - Left",
                    "Turtle Rock - Roller Room - Right",
                    "Turtle Rock - Chain Chomps",
                    "Turtle Rock - Big Key Chest",
                    "Turtle Rock - Big Chest",
                    "Turtle Rock - Crystaroller Room",
                    "Turtle Rock - Eye Bridge - Top Right",
                    "Turtle Rock - Eye Bridge - Top Left",
                    "Turtle Rock - Eye Bridge - Bottom Right",
                    "Turtle Rock - Eye Bridge - Bottom Left",
                    "Turtle Rock - Trinexx",
                },
                ["Ganon's Tower"] = new List<string>
                {
                    "Ganon's Tower - Bob's Torch",
                    "Ganon's Tower - DMs Room - Top Left",
                    "Ganon's Tower - DMs Room - Top Right",
                    "Ganon's Tower - DMs Room - Bottom Left",
                    "Ganon's Tower - DMs Room - Bottom Right",
                    "Ganon's Tower - Map Chest",
                    "Ganon's Tower - Firesnake Room",
                    "Ganon's Tower - Randomizer Room - Top Left",
                    "Ganon's Tower - Randomizer Room - Top Right",
                    "Ganon's Tower - Randomizer Room - Bottom Left",
                    "Ganon's Tower - Randomizer Room - Bottom Right",
                    "Ganon's Tower - Hope Room - Left",
                    "Ganon's Tower - Hope Room - Right",
                    "Ganon's Tower - Tile Room",
                    "Ganon's Tower - Compass Room - Top Left",
                    "Ganon's Tower - Compass Room - Top Right",
                    "Ganon's Tower - Compass Room - Bottom Left",
                    "Ganon's Tower - Compass Room - Bottom Right",
                    "Ganon's Tower - Bob's Chest",
                    "Ganon's Tower - Big Chest",
                    "Ganon's Tower - Big Key Chest",
                    "Ganon's Tower - Big Key Room - Left",
                    "Ganon's Tower - Big Key Room - Right",
                    "Ganon's Tower - Mini Helmasaur Room - Left",
                    "Ganon's Tower - Mini Helmasaur Room - Right",
                    "Ganon's Tower - Pre-Moldorm Chest",
                    "Ganon's Tower - Moldorm Chest",
                },
                ["Crateria"] = new List<string>
                {
                    "Energy Tank, Terminator",
                    "Energy Tank, Gauntlet",
                    "Missile (Crateria gauntlet right)",
                    "Missile (Crateria gauntlet left)",
                    "Power Bomb (Crateria surface)",
                    "Missile (Crateria middle)",
                    "Missile (Crateria bottom)",
                    "Super Missile (Crateria)",
                    "Bombs",
                    "Missile (outside Wrecked Ship bottom)",
                    "Missile (outside Wrecked Ship top)",
                    "Missile (outside Wrecked Ship middle)",
                    "Missile (Crateria moat)",
                },
                ["Brinstar"] = new List<string>
                {
                    "Morphing Ball",
                    "Power Bomb (blue Brinstar)",
                    "Missile (blue Brinstar middle)",
                    "Energy Tank, Brinstar Ceiling",
                    "Missile (blue Brinstar bottom)",
                    "Missile (blue Brinstar top)",
                    "Missile (blue Brinstar behind missile)",
                    "Power Bomb (green Brinstar bottom)",
                    "Missile (green Brinstar below super missile)",
                    "Super Missile (green Brinstar top)",
                    "Reserve Tank, Brinstar",
                    "Missile (green Brinstar behind missile)",
                    "Missile (green Brinstar behind reserve tank)",
                    "Energy Tank, Etecoons",
                    "Super Missile (green Brinstar bottom)",
                    "Super Missile (pink Brinstar)",
                    "Missile (pink Brinstar top)",
                    "Missile (pink Brinstar bottom)",
                    "Charge Beam",
                    "Power Bomb (pink Brinstar)",
                    "Missile (green Brinstar pipe)",
                    "Energy Tank, Waterway",
                    "Energy Tank, Brinstar Gate",
                    "X-Ray Scope",
                    "Power Bomb (red Brinstar sidehopper room)",
                    "Power Bomb (red Brinstar spike room)",
                    "Missile (red Brinstar spike room)",
                    "Spazer",
                    "Energy Tank, Kraid",
                    "Varia Suit",
                    "Missile (Kraid)",
                },
                ["Wrecked Ship"] = new List<string>
                {
                    "Missile (Wrecked Ship middle)",
                    "Reserve Tank, Wrecked Ship",
                    "Missile (Gravity Suit)",
                    "Missile (Wrecked Ship top)",
                    "Energy Tank, Wrecked Ship",
                    "Super Missile (Wrecked Ship left)",
                    "Right Super, Wrecked Ship",
                    "Gravity Suit",
                },
                ["Maridia"] = new List<string>
                {
                    "Missile (green Maridia shinespark)",
                    "Super Missile (green Maridia)",
                    "Energy Tank, Mama turtle",
                    "Missile (green Maridia tatori)",
                    "Super Missile (yellow Maridia)",
                    "Missile (yellow Maridia super missile)",
                    "Missile (yellow Maridia false wall)",
                    "Plasma Beam",
                    "Missile (left Maridia sand pit room)",
                    "Reserve Tank, Maridia",
                    "Missile (right Maridia sand pit room)",
                    "Power Bomb (right Maridia sand pit room)",
                    "Missile (pink Maridia)",
                    "Super Missile (pink Maridia)",
                    "Spring Ball",
                    "Missile (Draygon)",
                    "Energy Tank, Botwoon",
                    "Space Jump",
                },
                ["Upper Norfair"] = new List<string>
                {
                    "Missile (lava room)",
                    "Ice Beam",
                    "Missile (below Ice Beam)",
                    "Hi-Jump Boots",
                    "Missile (Hi-Jump Boots)",
                    "Energy Tank (Hi-Jump Boots)",
                    "Reserve Tank, Norfair",
                    "Missile (Norfair Reserve Tank)",
                    "Missile (bubble Norfair green door)",
                    "Missile (bubble Norfair)",
                    "Missile (Speed Booster)",
                    "Speed Booster",
                    "Missile (Wave Beam)",
                    "Wave Beam",
                    "Energy Tank, Crocomire",
                    "Missile (above Crocomire)",
                    "Power Bomb (Crocomire)",
                    "Missile (below Crocomire)",
                    "Missile (Grappling Beam)",
                    "Grappling Beam",
                },
                ["Lower Norfair"] = new List<string>
                {
                    "Missile (Gold Torizo)",
                    "Super Missile (Gold Torizo)",
                    "Screw Attack",
                    "Missile (Mickey Mouse room)",
                    "Missile (lower Norfair above fire flea room)",
                    "Power Bomb (lower Norfair above fire flea room)",
                    "Power Bomb (Power Bombs of shame)",
                    "Missile (lower Norfair near Wave Beam)",
                    "Energy Tank, Ridley",
                    "Energy Tank, Firefleas",
                }
            };

            AltLocations = new Dictionary<string, List<string>>
            {
                ["Light World"] = new List<string>
                {
                    "Aginah's Cave",
                    "Bombos Tablet",
                    "Checkerboard Cave",
                    "Desert Ledge",
                    "Graveyard Ledge",
                    "Hobo",
                    "Ice Rod Cave",
                    "Floodgate Chest",
                    "Flute Spot",
                    
                    "King's Tomb",
                    "King Zora",
                    "Lake Hylia Island",
                    "Mini Moldorm Cave - Far Left",
                    "Mini Moldorm Cave - Left",
                    "Mini Moldorm Cave - NPC",
                    "Mini Moldorm Cave - Right",
                    "Mini Moldorm Cave - Far Right",
                    "Potion Shop",

                    "South of Grove",
                    "Spectacle Rock",
                    "Spectacle Rock Cave",
                    "Sunken Treasure",
                    "Waterfall Fairy - Right",
                    "Waterfall Fairy - Left",
                    "Zora's Ledge"
                },
                ["North/North West LW"] = new List<string>
                {
                    "Lost Woods Hideout",
                    "Lumberjack Tree",
                    "Master Sword Pedestal",
                    "Mushroom",
                    "Pegasus Rocks",
                },
                ["Kakariko Village"] = new List<string>
                {

                    "Blind's Hideout - Top",
                    "Blind's Hideout - Far Left",
                    "Blind's Hideout - Left",
                    "Blind's Hideout - Right",
                    "Blind's Hideout - Far Right",
                    "Bottle Merchant",
                    "Chicken House",
                    "Kakariko Tavern",
                    "Kakariko Well - Top",
                    "Kakariko Well - Left",
                    "Kakariko Well - Middle",
                    "Kakariko Well - Right",
                    "Kakariko Well - Bottom",
                    "Library",
                    "Magic Bat",
                    "Maze Race",
                    "Sick Kid",
                },
                ["West LW DM"] = new List<string>
                {
                    "Floating Island",
                    "Mimic Cave",
                    "Paradox Cave Upper - Left",
                    "Paradox Cave Upper - Right",
                    "Paradox Cave Lower - Far Left",
                    "Paradox Cave Lower - Left",
                    "Paradox Cave Lower - Middle",
                    "Paradox Cave Lower - Right",
                    "Paradox Cave Lower - Far Right",
                    "Spiral Cave",
                },
                ["Central Hyrule"] = new List<string>
                {
                    "Link's House",
                    "Hyrule Castle - Boomerang Chest",
                    "Hyrule Castle - Map Chest",
                    "Hyrule Castle - Zelda's Cell",
                    "Link's Uncle",
                    "Sanctuary",
                    "Secret Passage",
                    "Sewers - Secret Room - Left",
                    "Sewers - Secret Room - Middle",
                    "Sewers - Secret Room - Right",
                    "Sewers - Dark Cross"
                },
                ["Castle Tower"] = new List<string>
                {
                    "Castle Tower - Foyer",
                    "Castle Tower - Dark Maze"
                },
                ["Eastern Area"] = new List<string>
                {
                    "Sahasrahla",
                    "Sahasrahla's Hut - Left",
                    "Sahasrahla's Hut - Middle",
                    "Sahasrahla's Hut - Right",
                    "Eastern Palace - Cannonball Chest",
                    "Eastern Palace - Map Chest",
                    "Eastern Palace - Compass Chest",
                    "Eastern Palace - Big Chest",
                    "Eastern Palace - Big Key Chest",
                    "Eastern Palace - Armos Knights",
                },
                ["Desert Palace"] = new List<string>
                {
                    "Desert Palace - Big Chest",
                    "Desert Palace - Torch",
                    "Desert Palace - Map Chest",
                    "Desert Palace - Big Key Chest",
                    "Desert Palace - Compass Chest",
                    "Desert Palace - Lanmolas",
                },
                ["East LW DM"] = new List<string>
                {
                    "Ether Tablet",
                    "Old Man",

                    "Tower of Hera - Basement Cage",
                    "Tower of Hera - Map Chest",
                    "Tower of Hera - Big Key Chest",
                    "Tower of Hera - Compass Chest",
                    "Tower of Hera - Big Chest",
                    "Tower of Hera - Moldorm",
                },
                ["Dark World"] = new List<string>
                {
                    "Spike Cave",
                    "Hookshot Cave - Top Right",
                    "Hookshot Cave - Top Left",
                    "Hookshot Cave - Bottom Left",
                    "Hookshot Cave - Bottom Right",
                    "Superbunny Cave - Top",
                    "Superbunny Cave - Bottom",
                    "Bumper Cave",
                    
                    "Catfish",
                    "Pyramid",
                    "Pyramid Fairy - Left",
                    "Pyramid Fairy - Right",
                    "Digging Game",
                    "Stumpy",
                    "Hype Cave - Top",
                    "Hype Cave - Middle Right",
                    "Hype Cave - Middle Left",
                    "Hype Cave - Bottom",
                    "Hype Cave - NPC",
                    
                },
                ["Palace of Darkness"] = new List<string>
                {
                    "Palace of Darkness - Shooter Room",
                    "Palace of Darkness - Big Key Chest",
                    "Palace of Darkness - Stalfos Basement",
                    "Palace of Darkness - The Arena - Bridge",
                    "Palace of Darkness - The Arena - Ledge",
                    "Palace of Darkness - Map Chest",
                    "Palace of Darkness - Compass Chest",
                    "Palace of Darkness - Harmless Hellway",
                    "Palace of Darkness - Dark Basement - Left",
                    "Palace of Darkness - Dark Basement - Right",
                    "Palace of Darkness - Dark Maze - Top",
                    "Palace of Darkness - Dark Maze - Bottom",
                    "Palace of Darkness - Big Chest",
                    "Palace of Darkness - Helmasaur King",
                },
                ["Swamp Palace"] = new List<string>
                {
                    "Swamp Palace - Entrance",
                    "Swamp Palace - Map Chest",
                    "Swamp Palace - Big Chest",
                    "Swamp Palace - Compass Chest",
                    "Swamp Palace - West Chest",
                    "Swamp Palace - Big Key Chest",
                    "Swamp Palace - Flooded Room - Left",
                    "Swamp Palace - Flooded Room - Right",
                    "Swamp Palace - Waterfall Room",
                    "Swamp Palace - Arrghus",
                },
                ["Skull Woods"] = new List<string>
                {
                    "Skull Woods - Pot Prison",
                    "Skull Woods - Compass Chest",
                    "Skull Woods - Big Chest",
                    "Skull Woods - Map Chest",
                    "Skull Woods - Pinball Room",
                    "Skull Woods - Big Key Chest",
                    "Skull Woods - Bridge Room",
                    "Skull Woods - Mothula",
                },
                ["Village of Outcasts"] = new List<string>
                {
                    "Chest Game",
                    "C-Shaped House",
                    "Brewery",
                    "Hammer Pegs",
                    "Blacksmith",
                    "Purple Chest",
                    "Thieves' Town - Map Chest",
                    "Thieves' Town - Ambush Chest",
                    "Thieves' Town - Compass Chest",
                    "Thieves' Town - Big Key Chest",
                    "Thieves' Town - Attic",
                    "Thieves' Town - Blind's Cell",
                    "Thieves' Town - Big Chest",
                    "Thieves' Town - Blind",
                },
                ["Ice Palace"] = new List<string>
                {
                    "Ice Palace - Compass Chest",
                    "Ice Palace - Spike Room",
                    "Ice Palace - Map Chest",
                    "Ice Palace - Big Key Chest",
                    "Ice Palace - Iced T Room",
                    "Ice Palace - Freezor Chest",
                    "Ice Palace - Big Chest",
                    "Ice Palace - Kholdstare",
                },
                ["Mire Area"] = new List<string>
                {
                    "Misery Mire - Main Lobby",
                    "Misery Mire - Map Chest",
                    "Misery Mire - Bridge Chest",
                    "Misery Mire - Spike Chest",
                    "Misery Mire - Compass Chest",
                    "Misery Mire - Big Key Chest",
                    "Misery Mire - Big Chest",
                    "Misery Mire - Vitreous",
                    "Mire Shed - Left",
                    "Mire Shed - Right",
                },
                ["Turtle Rock"] = new List<string>
                {
                    "Turtle Rock - Compass Chest",
                    "Turtle Rock - Roller Room - Left",
                    "Turtle Rock - Roller Room - Right",
                    "Turtle Rock - Chain Chomps",
                    "Turtle Rock - Big Key Chest",
                    "Turtle Rock - Big Chest",
                    "Turtle Rock - Crystaroller Room",
                    "Turtle Rock - Eye Bridge - Top Right",
                    "Turtle Rock - Eye Bridge - Top Left",
                    "Turtle Rock - Eye Bridge - Bottom Right",
                    "Turtle Rock - Eye Bridge - Bottom Left",
                    "Turtle Rock - Trinexx",
                },
                ["Ganon's Tower"] = new List<string>
                {
                    "Ganon's Tower - Bob's Torch",
                    "Ganon's Tower - DMs Room - Top Left",
                    "Ganon's Tower - DMs Room - Top Right",
                    "Ganon's Tower - DMs Room - Bottom Left",
                    "Ganon's Tower - DMs Room - Bottom Right",
                    "Ganon's Tower - Map Chest",
                    "Ganon's Tower - Firesnake Room",
                    "Ganon's Tower - Randomizer Room - Top Left",
                    "Ganon's Tower - Randomizer Room - Top Right",
                    "Ganon's Tower - Randomizer Room - Bottom Left",
                    "Ganon's Tower - Randomizer Room - Bottom Right",
                    "Ganon's Tower - Hope Room - Left",
                    "Ganon's Tower - Hope Room - Right",
                    "Ganon's Tower - Tile Room",
                    "Ganon's Tower - Compass Room - Top Left",
                    "Ganon's Tower - Compass Room - Top Right",
                    "Ganon's Tower - Compass Room - Bottom Left",
                    "Ganon's Tower - Compass Room - Bottom Right",
                    "Ganon's Tower - Bob's Chest",
                    "Ganon's Tower - Big Chest",
                    "Ganon's Tower - Big Key Chest",
                    "Ganon's Tower - Big Key Room - Left",
                    "Ganon's Tower - Big Key Room - Right",
                    "Ganon's Tower - Mini Helmasaur Room - Left",
                    "Ganon's Tower - Mini Helmasaur Room - Right",
                    "Ganon's Tower - Pre-Moldorm Chest",
                    "Ganon's Tower - Moldorm Chest",
                },
                ["Crateria"] = new List<string>
                {
                    "Energy Tank, Terminator",
                    "Energy Tank, Gauntlet",
                    "Missile (Crateria gauntlet right)",
                    "Missile (Crateria gauntlet left)",
                    "Power Bomb (Crateria surface)",
                    "Missile (Crateria middle)",
                    "Missile (Crateria bottom)",
                    "Super Missile (Crateria)",
                    "Bombs",
                    "Morphing Ball",
                    "Power Bomb (blue Brinstar)",
                    "Missile (blue Brinstar middle)",
                    "Energy Tank, Brinstar Ceiling",
                    "Missile (blue Brinstar bottom)",
                    "Missile (blue Brinstar top)",
                },
                ["Green/Pink Brin"] = new List<string>
                {
                    "Power Bomb (green Brinstar bottom)",
                    "Missile (green Brinstar below super missile)",
                    "Super Missile (green Brinstar top)",
                    "Reserve Tank, Brinstar",
                    "Missile (green Brinstar behind missile)",
                    "Missile (green Brinstar behind reserve tank)",
                    "Energy Tank, Etecoons",
                    "Super Missile (green Brinstar bottom)",
                    "Super Missile (pink Brinstar)",
                    "Missile (pink Brinstar top)",
                    "Missile (pink Brinstar bottom)",
                    "Charge Beam",
                    "Power Bomb (pink Brinstar)",
                    "Missile (green Brinstar pipe)",
                    "Energy Tank, Waterway",
                    "Energy Tank, Brinstar Gate",
                },
                ["Red Brin/Kraid"] = new List<string>
                {
                    "X-Ray Scope",
                    "Power Bomb (red Brinstar sidehopper room)",
                    "Power Bomb (red Brinstar spike room)",
                    "Missile (red Brinstar spike room)",
                    "Spazer",
                    "Energy Tank, Kraid",
                    "Varia Suit",
                    "Missile (Kraid)",
                },
                ["Wrecked Ship"] = new List<string>
                {
                    "Missile (blue Brinstar behind missile)",
                    "Missile (outside Wrecked Ship bottom)",
                    "Missile (outside Wrecked Ship top)",
                    "Missile (outside Wrecked Ship middle)",
                    "Missile (Crateria moat)",
                    "Missile (Wrecked Ship middle)",
                    "Reserve Tank, Wrecked Ship",
                    "Missile (Gravity Suit)",
                    "Missile (Wrecked Ship top)",
                    "Energy Tank, Wrecked Ship",
                    "Super Missile (Wrecked Ship left)",
                    "Right Super, Wrecked Ship",
                    "Gravity Suit",
                },
                ["East Maridia"] = new List<string>
                {
                    "Missile (green Maridia shinespark)",
                    "Super Missile (green Maridia)",
                    "Energy Tank, Mama turtle",
                    "Missile (green Maridia tatori)",
                    "Super Missile (yellow Maridia)",
                    "Missile (yellow Maridia super missile)",
                    "Missile (yellow Maridia false wall)",
                },
                ["West Maridia"] = new List<string>
                {
                    "Spring Ball",
                    "Missile (Draygon)",
                    "Energy Tank, Botwoon",
                    "Space Jump",
                    "Plasma Beam",
                    "Missile (left Maridia sand pit room)",
                    "Reserve Tank, Maridia",
                    "Missile (right Maridia sand pit room)",
                    "Power Bomb (right Maridia sand pit room)",
                    "Missile (pink Maridia)",
                    "Super Missile (pink Maridia)",
                },
                ["Business Center"] = new List<string>
                {
                    "Missile (lava room)",
                    "Ice Beam",
                    "Missile (below Ice Beam)",
                    "Hi-Jump Boots",
                    "Missile (Hi-Jump Boots)",
                    "Energy Tank (Hi-Jump Boots)",
                },
                ["Bubble Mountain"] = new List<string>
                {
                    "Reserve Tank, Norfair",
                    "Missile (Norfair Reserve Tank)",
                    "Missile (bubble Norfair green door)",
                    "Missile (bubble Norfair)",
                    "Missile (Speed Booster)",
                    "Speed Booster",
                    "Missile (Wave Beam)",
                    "Wave Beam",
                },
                ["Crocomire"] = new List<string>
                {
                    "Energy Tank, Crocomire",
                    "Missile (above Crocomire)",
                    "Power Bomb (Crocomire)",
                    "Missile (below Crocomire)",
                    "Missile (Grappling Beam)",
                    "Grappling Beam",
                },
                ["Lower Norfair"] = new List<string>
                {
                    "Missile (Gold Torizo)",
                    "Super Missile (Gold Torizo)",
                    "Screw Attack",
                    "Missile (Mickey Mouse room)",
                    "Missile (lower Norfair above fire flea room)",
                    "Power Bomb (lower Norfair above fire flea room)",
                    "Power Bomb (Power Bombs of shame)",
                    "Missile (lower Norfair near Wave Beam)",
                    "Energy Tank, Ridley",
                    "Energy Tank, Firefleas",
                }
            };
        }
    }
}

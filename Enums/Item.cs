﻿using smz3.countdown.wasm.Attributes;
using System.ComponentModel;

namespace smz3.countdown.wasm.Enums
{
    public enum Item
    {
        [Key]
        [Description("Hyrule Castle Map")]
        MapHC = 0x7F,
        
        [Key]
        [Description("Eastern Palace Map")]
        MapEP = 0x7D,
        
        [Key]
        [Description("Desert Palace Map")]
        MapDP = 0x7C,
        
        [Key]
        [Description("Tower of Hera Map")]
        MapTH = 0x75,
        
        [Key]
        [Description("Palace of Darkness Map")]
        MapPD = 0x79,
        
        [Key]
        [Description("Swamp Palace Map")]
        MapSP = 0x7A,
        
        [Key]
        [Description("Skull Woods Map")]
        MapSW = 0x77,
        
        [Key]
        [Description("Thieves Town Map")]
        MapTT = 0x74,
        
        [Key]
        [Description("Ice Palace Map")]
        MapIP = 0x76,
        
        [Key]
        [Description("Misery Mire Map")]
        MapMM = 0x78,
        
        [Key]
        [Description("Turtle Rock Map")]
        MapTR = 0x73,
        
        [Key]
        [Description("Ganons Tower Map")]
        MapGT = 0x72,

        [Key]
        [Description("Eastern Palace Big Key")]
        BigKeyEP = 0x9D,
        
        [Key]
        [Description("Desert Palace Big Key")]
        BigKeyDP = 0x9C,
        
        [Key]
        [Description("Tower of Hera Big Key")]
        BigKeyTH = 0x95,
        
        [Key]
        [Description("Palace of Darkness Big Key")]
        BigKeyPD = 0x99,

        [Key]
        [Description("Swamp Palace Big Key")]
        BigKeySP = 0x9A,

        [Key]
        [Description("Skull Woods Big Key")]
        BigKeySW = 0x97,

        [Key]
        [Description("Thieves Town Big Key")]
        BigKeyTT = 0x94,

        [Key]
        [Description("Ice Palace Big Key")]
        BigKeyIP = 0x96,

        [Key]
        [Description("Misery Mire Big Key")]
        BigKeyMM = 0x98,

        [Key]
        [Description("Turtle Rock Big Key")]
        BigKeyTR = 0x93,

        [Key]
        [Description("Ganons Tower Big Key")]
        BigKeyGT = 0x92,


        [Key]
        [Description("Sewer Key")]
        KeyHC = 0xA0,

        [Key]
        [Description("Castle Tower Key")]
        KeyCT = 0xA4,

        [Key]
        [Description("Desert Palace Key")]
        KeyDP = 0xA3,

        [Key]
        [Description("Tower of Hera Key")]
        KeyTH = 0xAA,

        [Key]
        [Description("Palace of Darkness Key")]
        KeyPD = 0xA6,

        [Key]
        [Description("Swamp Palace Key")]
        KeySP = 0xA5,

        [Key]
        [Description("Skull Woods Key")]
        KeySW = 0xA8,

        [Key]
        [Description("Thieves Town Key")]
        KeyTT = 0xAB,

        [Key]
        [Description("Ice Palace Key")]
        KeyIP = 0xA9,

        [Key]
        [Description("Misery Mire Key")]
        KeyMM = 0xA7,

        [Key]
        [Description("Turtle Rock Key")]
        KeyTR = 0xAC,

        [Key]
        [Description("Ganons Tower Key")]
        KeyGT = 0xAD,

        [Major]
        [Description("Progressive Mail")]
        ProgressiveTunic = 0x60,
        [Major]
        [Description("Progressive Shield")]
        ProgressiveShield = 0x5F,
        [Major]
        [Description("Progressive Sword")]
        ProgressiveSword = 0x5E,
        [Major]
        [Description("Bow")]
        Bow = 0x0B,
        [Major]
        [Description("Silver Arrows")]
        SilverArrows = 0x58,
        [Major]
        [Description("Blue Boomerang")]
        BlueBoomerang = 0x0C,
        [Major]
        [Description("Red Boomerang")]
        RedBoomerang = 0x2A,
        [Major]
        [Description("Hookshot")]
        Hookshot = 0x0A,
        [Major]
        [Description("Mushroom")]
        Mushroom = 0x29,
        [Major]
        [Description("Magic Powder")]
        Powder = 0x0D,
        [Major]
        [Description("Fire Rod")]
        Firerod = 0x07,
        [Major]
        [Description("Ice Rod")]
        Icerod = 0x08,
        [Major]
        [Description("Bombos")]
        Bombos = 0x0f,
        [Major]
        [Description("Ether")]
        Ether = 0x10,
        [Major]
        [Description("Quake")]
        Quake = 0x11,
        [Major]
        [Description("Lamp")]
        Lamp = 0x12,
        [Major]
        [Description("Hammer")]
        Hammer = 0x09,
        [Major]
        [Description("Shovel")]
        Shovel = 0x13,
        [Major]
        [Description("Flute")]
        Flute = 0x14,
        [Major]
        [Description("Bug Catching Net")]
        Bugnet = 0x21,
        [Major]
        [Description("Book of Mudora")]
        Book = 0x1D,
        [Major]
        [Description("Bottle")]
        Bottle = 0x16,
        [Major]
        [Description("Cane of Somaria")]
        Somaria = 0x15,
        [Major]
        [Description("Cane of Byrna")]
        Byrna = 0x18,
        [Major]
        [Description("Magic Cape")]
        Cape = 0x19,
        [Major]
        [Description("Magic Mirror")]
        Mirror = 0x1A,
        [Major]
        [Description("Pegasus Boots")]
        Boots = 0x4B,
        [Major]
        [Description("Progressive Glove")]
        ProgressiveGlove = 0x61,
        [Major]
        [Description("Zora's Flippers")]
        Flippers = 0x1E,
        [Major]
        [Description("Moon Pearl")]
        MoonPearl = 0x1F,
        [Major]
        [Description("Half Magic")]
        HalfMagic = 0x4E,
        [Description("Piece of Heart")]
        HeartPiece = 0x17,
        [Description("Heart Container")]
        HeartContainer = 0x3E,
        [Description("Sanctuary Heart Container")]
        HeartContainerRefill = 0x3F,
        [Description("Three Bombs")]
        ThreeBombs = 0x28,
        [Description("Single Arrow")]
        Arrow = 0x43,
        [Description("Ten Arrows")]
        TenArrows = 0x44,
        [Description("One Rupee")]
        OneRupee = 0x34,
        [Description("Five Rupees")]
        FiveRupees = 0x35,
        [Description("Twenty Rupees")]
        TwentyRupees = 0x36,
        [Description("Twenty Rupees")]
        TwentyRupees2 = 0x47,
        [Description("Fifty Rupees")]
        FiftyRupees = 0x41,
        [Description("One Hundred Rupees")]
        OneHundredRupees = 0x40,
        [Description("Three Hundred Rupees")]
        ThreeHundredRupees = 0x46,
        [Description("+5 Bomb Capacity")]
        BombUpgrade5 = 0x51,
        [Description("+10 Bomb Capacity")]
        BombUpgrade10 = 0x52,
        [Description("+5 Arrow Capacity")]
        ArrowUpgrade5 = 0x53,
        [Description("+10 Arrow Capacity")]
        ArrowUpgrade10 = 0x54,

        [Key]
        [Description("Crateria Level 1 Keycard")]
        CardCrateriaL1 = 0xD0,

        [Key]
        [Description("Crateria Level 2 Keycard")]
        CardCrateriaL2 = 0xD1,

        [Key]
        [Description("Crateria Boss Keycard")]
        CardCrateriaBoss = 0xD2,

        [Key]
        [Description("Brinstar Level 1 Keycard")]
        CardBrinstarL1 = 0xD3,

        [Key]
        [Description("Brinstar Level 2 Keycard")]
        CardBrinstarL2 = 0xD4,

        [Key]
        [Description("Brinstar Boss Keycard")]
        CardBrinstarBoss = 0xD5,

        [Key]
        [Description("Norfair Level 1 Keycard")]
        CardNorfairL1 = 0xD6,

        [Key]
        [Description("Norfair Level 2 Keycard")]
        CardNorfairL2 = 0xD7,

        [Key]
        [Description("Norfair Boss Keycard")]
        CardNorfairBoss = 0xD8,

        [Key]
        [Description("Maridia Level 1 Keycard")]
        CardMaridiaL1 = 0xD9,

        [Key]
        [Description("Maridia Level 2 Keycard")]
        CardMaridiaL2 = 0xDA,

        [Key]
        [Description("Maridia Boss Keycard")]
        CardMaridiaBoss = 0xDB,

        [Key]
        [Description("Wrecked Ship Level 1 Keycard")]
        CardWreckedShipL1 = 0xDC,

        [Key]
        [Description("Wrecked Ship Boss Keycard")]
        CardWreckedShipBoss = 0xDD,

        [Key]
        [Description("Lower Norfair Level 1 Keycard")]
        CardLowerNorfairL1 = 0xDE,

        [Key]
        [Description("Lower Norfair Boss Keycard")]
        CardLowerNorfairBoss = 0xDF,

        [Key]
        [Description("Brinstar Map")]
        SmMapBrinstar = 0xCA,

        [Key]
        [Description("Wrecked Ship Map")]
        SmMapWreckedShip = 0xCB,

        [Key]
        [Description("Maridia Map")]
        SmMapMaridia = 0xCC,

        [Key]
        [Description("Lower Norfair Map")]
        SmMapLowerNorfair = 0xCD,

        [Description("Missile")]
        Missile = 0xC2,
        [Description("Super Missile")]
        Super = 0xC3,
        [Description("Power Bomb")]
        PowerBomb = 0xC4,
        [Major]
        [Description("Grappling Beam")]
        Grapple = 0xB0,
        [Major]
        [Description("X-Ray Scope")]
        XRay = 0xB1,
        [Description("Energy Tank")]
        ETank = 0xC0,
        [Description("Reserve Tank")]
        ReserveTank = 0xC1,
        [Major]
        [Description("Charge Beam")]
        Charge = 0xBB,
        [Major]
        [Description("Ice Beam")]
        Ice = 0xBC,
        [Major]
        [Description("Wave Beam")]
        Wave = 0xBD,
        [Major]
        [Description("Spazer")]
        Spazer = 0xBE,
        [Major]
        [Description("Plasma Beam")]
        Plasma = 0xBF,
        [Major]
        [Description("Varia Suit")]
        Varia = 0xB2,
        [Major]
        [Description("Gravity Suit")]
        Gravity = 0xB6,
        [Major]
        [Description("Morphing Ball")]
        Morph = 0xB4,
        [Major]
        [Description("Morph Bombs")]
        Bombs = 0xB9,
        [Major]
        [Description("Spring Ball")]
        SpringBall = 0xB3,
        [Major]
        [Description("Screw Attack")]
        ScrewAttack = 0xB5,
        [Major]
        [Description("Hi-Jump Boots")]
        HiJump = 0xB7,
        [Major]
        [Description("Space Jump")]
        SpaceJump = 0xB8,
        [Major]
        [Description("Speed Booster")]
        SpeedBooster = 0xBA,
    }
}

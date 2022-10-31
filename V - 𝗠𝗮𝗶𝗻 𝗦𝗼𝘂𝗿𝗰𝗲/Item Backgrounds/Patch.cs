
using Sprite = UnityEngine.Sprite;

using System.Reflection;
using System.IO;

using static SMLHelper.V2.Handlers.CraftDataHandler;
using SMLHelper.V2.Utility;
using SMLHelper.V2.Handlers;

using static CraftData;

namespace ItemBackgrounds
{
    public static class MainClass
    {
        public static BackgroundType Black = BackgroundTypeHandler.AddBackgroundType("Black", Sprites.Black);
        public static BackgroundType Blue = BackgroundTypeHandler.AddBackgroundType("Blue", Sprites.Blue);
        public static BackgroundType Green = BackgroundTypeHandler.AddBackgroundType("Green", Sprites.Green);
        public static BackgroundType LightBlue = BackgroundTypeHandler.AddBackgroundType("LightBlue", Sprites.LightBlue);
        public static BackgroundType Orange = BackgroundTypeHandler.AddBackgroundType("Orange", Sprites.Orange);
        public static BackgroundType Pink = BackgroundTypeHandler.AddBackgroundType("Pink", Sprites.Pink);
        public static BackgroundType Purple = BackgroundTypeHandler.AddBackgroundType("Pink", Sprites.Purple);
        public static BackgroundType Red = BackgroundTypeHandler.AddBackgroundType("Pink", Sprites.Red);
        public static BackgroundType White = BackgroundTypeHandler.AddBackgroundType("Pink", Sprites.White);
        public static BackgroundType Yellow = BackgroundTypeHandler.AddBackgroundType("Pink", Sprites.Yellow);

        public const string Default_ = "0/0 - None";
        public const string Red_ = "<color=#F07573>1/10 - Red</color>";
        public const string Orange_ = "<color=#FFA000>2/10 - Orange</color>";
        public const string Yellow_ = "<color=#FFD54F>3/10 - Yellow</color>";
        public const string Green_ = "<color=#81C784>4/10 - Green</color>";
        public const string Blue_ = "<color=#1E88E5>5/10 - Blue</color>";
        public const string LightBlue_ = "<color=#26C6DA>6/10 - Light Blue</color>";
        public const string Pink_ = "<color=#E988A9>7/10 - Pink</color>";
        public const string Purple_ = "<color=#945DB6>8/10 - Purple</color>";
        public const string White_ = "<color=#FFFFFF>9/10 - White</color>";
        public const string Black_ = "<color=#2f2f2e>10/10 - Black</color>";

        public static void PatchTools()
        {
            var Config = MyConfig.Config;

            if (Config.configTools == Default_){ foreach (TechType techType in Tools.techTypes) SetBackgroundType(techType, BackgroundType.Normal); }else
            if (Config.configTools == Red_) { foreach (TechType techType in Tools.techTypes) SetBackgroundType(techType, Red); }else
            if (Config.configTools == Orange_) { foreach (TechType techType in Tools.techTypes) SetBackgroundType(techType, Orange); }else
            if (Config.configTools == Yellow_) { foreach (TechType techType in Tools.techTypes) SetBackgroundType(techType, Yellow); }else
            if (Config.configTools == Green_) { foreach (TechType techType in Tools.techTypes) SetBackgroundType(techType, Green); }else
            if (Config.configTools == Blue_) { foreach (TechType techType in Tools.techTypes) SetBackgroundType(techType, Blue); }else
            if (Config.configTools == LightBlue_) { foreach (TechType techType in Tools.techTypes) SetBackgroundType(techType, LightBlue); }else
            if (Config.configTools == Pink_) { foreach (TechType techType in Tools.techTypes) SetBackgroundType(techType, Pink); }else
            if (Config.configTools == Purple_) { foreach (TechType techType in Tools.techTypes) SetBackgroundType(techType, Purple); }else
            if (Config.configTools == White_) { foreach (TechType techType in Tools.techTypes) SetBackgroundType(techType, White); }else
            if (Config.configTools == Black_) { foreach (TechType techType in Tools.techTypes) SetBackgroundType(techType, Black); }
        }
        public static void PatchResources()
        {
            var Config = MyConfig.Config;

            if (Config.configResource == Default_){ foreach (TechType techType in Resources.techTypes) SetBackgroundType(techType, BackgroundType.Normal); }else
            if (Config.configResource == Red_) { foreach (TechType techType in Resources.techTypes) SetBackgroundType(techType, Red); }else
            if (Config.configResource == Orange_) { foreach (TechType techType in Resources.techTypes) SetBackgroundType(techType, Orange); }else
            if (Config.configResource == Yellow_) { foreach (TechType techType in Resources.techTypes) SetBackgroundType(techType, Yellow); }else
            if (Config.configResource == Green_) { foreach (TechType techType in Resources.techTypes) SetBackgroundType(techType, Green); }else
            if (Config.configResource == Blue_) { foreach (TechType techType in Resources.techTypes) SetBackgroundType(techType, Blue); }else
            if (Config.configResource == LightBlue_) { foreach (TechType techType in Resources.techTypes) SetBackgroundType(techType, LightBlue); }else
            if (Config.configResource == Pink_) { foreach (TechType techType in Resources.techTypes) SetBackgroundType(techType, Pink); }else
            if (Config.configResource == Purple_) { foreach (TechType techType in Resources.techTypes) SetBackgroundType(techType, Purple); }else
            if (Config.configResource == White_) { foreach (TechType techType in Resources.techTypes) SetBackgroundType(techType, White); }else
            if (Config.configResource == Black_) { foreach (TechType techType in Resources.techTypes) SetBackgroundType(techType, Black); }
        }
        public static void PatchElectronics()
        {
            var Config = MyConfig.Config;

            if (Config.configElec == Default_){ foreach (TechType techType in Electronics.techTypes) SetBackgroundType(techType, BackgroundType.Normal); }else
            if (Config.configElec == Red_) { foreach (TechType techType in Electronics.techTypes) SetBackgroundType(techType, Red); }else
            if (Config.configElec == Orange_) { foreach (TechType techType in Electronics.techTypes) SetBackgroundType(techType, Orange); }else
            if (Config.configElec == Yellow_) { foreach (TechType techType in Electronics.techTypes) SetBackgroundType(techType, Yellow); }else
            if (Config.configElec == Green_) { foreach (TechType techType in Electronics.techTypes) SetBackgroundType(techType, Green); }else
            if (Config.configElec == Blue_) { foreach (TechType techType in Electronics.techTypes) SetBackgroundType(techType, Blue); }else
            if (Config.configElec == LightBlue_) { foreach (TechType techType in Electronics.techTypes) SetBackgroundType(techType, LightBlue); }else
            if (Config.configElec == Pink_) { foreach (TechType techType in Electronics.techTypes) SetBackgroundType(techType, Pink); }else
            if (Config.configElec == Purple_) { foreach (TechType techType in Electronics.techTypes) SetBackgroundType(techType, Purple); }else
            if (Config.configElec == White_) { foreach (TechType techType in Electronics.techTypes) SetBackgroundType(techType, White); }else
            if (Config.configElec == Black_) { foreach (TechType techType in Electronics.techTypes) SetBackgroundType(techType, Black); }
        }
        public static void PatchSynthetics()
        {
            var Config = MyConfig.Config;

            if (Config.configSynth == Default_){ foreach (TechType techType in Synthetics.techTypes) SetBackgroundType(techType, BackgroundType.Normal); }else
            if (Config.configSynth == Red_) { foreach (TechType techType in Synthetics.techTypes) SetBackgroundType(techType, Red); }else
            if (Config.configSynth == Orange_) { foreach (TechType techType in Synthetics.techTypes) SetBackgroundType(techType, Orange); }else
            if (Config.configSynth == Yellow_) { foreach (TechType techType in Synthetics.techTypes) SetBackgroundType(techType, Yellow); }else
            if (Config.configSynth == Green_) { foreach (TechType techType in Synthetics.techTypes) SetBackgroundType(techType, Green); }else
            if (Config.configSynth == Blue_) { foreach (TechType techType in Synthetics.techTypes) SetBackgroundType(techType, Blue); }else
            if (Config.configSynth == LightBlue_) { foreach (TechType techType in Synthetics.techTypes) SetBackgroundType(techType, LightBlue); }else
            if (Config.configSynth == Pink_) { foreach (TechType techType in Synthetics.techTypes) SetBackgroundType(techType, Pink); }else
            if (Config.configSynth == Purple_) { foreach (TechType techType in Synthetics.techTypes) SetBackgroundType(techType, Purple); }else
            if (Config.configSynth == White_) { foreach (TechType techType in Synthetics.techTypes) SetBackgroundType(techType, White); }else
            if (Config.configSynth == Black_) { foreach (TechType techType in Synthetics.techTypes) SetBackgroundType(techType, Black); }
        }
        public static void PatchLandFlora()
        {
            var Config = MyConfig.Config;

            if (Config.configLand == Default_){ foreach (TechType techType in LandFlora.techTypes) SetBackgroundType(techType, BackgroundType.Normal); }else
            if (Config.configLand == Red_) { foreach (TechType techType in LandFlora.techTypes) SetBackgroundType(techType, Red); }else
            if (Config.configLand == Orange_) { foreach (TechType techType in LandFlora.techTypes) SetBackgroundType(techType, Orange); }else
            if (Config.configLand == Yellow_) { foreach (TechType techType in LandFlora.techTypes) SetBackgroundType(techType, Yellow); }else
            if (Config.configLand == Green_) { foreach (TechType techType in LandFlora.techTypes) SetBackgroundType(techType, Green); }else
            if (Config.configLand == Blue_) { foreach (TechType techType in LandFlora.techTypes) SetBackgroundType(techType, Blue); }else
            if (Config.configLand == LightBlue_) { foreach (TechType techType in LandFlora.techTypes) SetBackgroundType(techType, LightBlue); }else
            if (Config.configLand == Pink_) { foreach (TechType techType in LandFlora.techTypes) SetBackgroundType(techType, Pink); }else
            if (Config.configLand == Purple_) { foreach (TechType techType in LandFlora.techTypes) SetBackgroundType(techType, Purple); }else
            if (Config.configLand == White_) { foreach (TechType techType in LandFlora.techTypes) SetBackgroundType(techType, White); }else
            if (Config.configLand == Black_) { foreach (TechType techType in LandFlora.techTypes) SetBackgroundType(techType, Black); }
        }
        public static void PatchWaterFlora()
        {
            var Config = MyConfig.Config;

            if (Config.configWater == Default_){ foreach (TechType techType in WaterFlora.techTypes) SetBackgroundType(techType, BackgroundType.Normal); }else
            if (Config.configWater == Red_) { foreach (TechType techType in WaterFlora.techTypes) SetBackgroundType(techType, Red); }else
            if (Config.configWater == Orange_) { foreach (TechType techType in WaterFlora.techTypes) SetBackgroundType(techType, Orange); }else
            if (Config.configWater == Yellow_) { foreach (TechType techType in WaterFlora.techTypes) SetBackgroundType(techType, Yellow); }else
            if (Config.configWater == Green_) { foreach (TechType techType in WaterFlora.techTypes) SetBackgroundType(techType, Green); }else
            if (Config.configWater == Blue_) { foreach (TechType techType in WaterFlora.techTypes) SetBackgroundType(techType, Blue); }else
            if (Config.configWater == LightBlue_) { foreach (TechType techType in WaterFlora.techTypes) SetBackgroundType(techType, LightBlue); }else
            if (Config.configWater == Pink_) { foreach (TechType techType in WaterFlora.techTypes) SetBackgroundType(techType, Pink); }else
            if (Config.configWater == Purple_) { foreach (TechType techType in WaterFlora.techTypes) SetBackgroundType(techType, Purple); }else
            if (Config.configWater == White_) { foreach (TechType techType in WaterFlora.techTypes) SetBackgroundType(techType, White); }else
            if (Config.configWater == Black_) { foreach (TechType techType in WaterFlora.techTypes) SetBackgroundType(techType, Black); }
        }
        public static void PatchRaw()
        {
            var Config = MyConfig.Config;

            if (Config.configRaw == Default_){ foreach (TechType techType in RawFish.techTypes) SetBackgroundType(techType, BackgroundType.Normal); }else
            if (Config.configRaw == Red_) { foreach (TechType techType in RawFish.techTypes) SetBackgroundType(techType, Red); }else
            if (Config.configRaw == Orange_) { foreach (TechType techType in RawFish.techTypes) SetBackgroundType(techType, Orange); }else
            if (Config.configRaw == Yellow_) { foreach (TechType techType in RawFish.techTypes) SetBackgroundType(techType, Yellow); }else
            if (Config.configRaw == Green_) { foreach (TechType techType in RawFish.techTypes) SetBackgroundType(techType, Green); }else
            if (Config.configRaw == Blue_) { foreach (TechType techType in RawFish.techTypes) SetBackgroundType(techType, Blue); }else
            if (Config.configRaw == LightBlue_) { foreach (TechType techType in RawFish.techTypes) SetBackgroundType(techType, LightBlue); }else
            if (Config.configRaw == Pink_) { foreach (TechType techType in RawFish.techTypes) SetBackgroundType(techType, Pink); }else
            if (Config.configRaw == Purple_) { foreach (TechType techType in RawFish.techTypes) SetBackgroundType(techType, Purple); }else
            if (Config.configRaw == White_) { foreach (TechType techType in RawFish.techTypes) SetBackgroundType(techType, White); }else
            if (Config.configRaw == Black_) { foreach (TechType techType in RawFish.techTypes) SetBackgroundType(techType, Black); }
        }
        public static void PatchCooked()
        {
            var Config = MyConfig.Config;

            if (Config.configCooked == Default_){ foreach (TechType techType in CookedFish.techTypes) SetBackgroundType(techType, BackgroundType.Normal); }else
            if (Config.configCooked == Red_) { foreach (TechType techType in CookedFish.techTypes) SetBackgroundType(techType, Red); }else
            if (Config.configCooked == Orange_) { foreach (TechType techType in CookedFish.techTypes) SetBackgroundType(techType, Orange); }else
            if (Config.configCooked == Yellow_) { foreach (TechType techType in CookedFish.techTypes) SetBackgroundType(techType, Yellow); }else
            if (Config.configCooked == Green_) { foreach (TechType techType in CookedFish.techTypes) SetBackgroundType(techType, Green); }else
            if (Config.configCooked == Blue_) { foreach (TechType techType in CookedFish.techTypes) SetBackgroundType(techType, Blue); }else
            if (Config.configCooked == LightBlue_) { foreach (TechType techType in CookedFish.techTypes) SetBackgroundType(techType, LightBlue); }else
            if (Config.configCooked == Pink_) { foreach (TechType techType in CookedFish.techTypes) SetBackgroundType(techType, Pink); }else
            if (Config.configCooked == Purple_) { foreach (TechType techType in CookedFish.techTypes) SetBackgroundType(techType, Purple); }else
            if (Config.configCooked == White_) { foreach (TechType techType in CookedFish.techTypes) SetBackgroundType(techType, White); }else
            if (Config.configCooked == Black_) { foreach (TechType techType in CookedFish.techTypes) SetBackgroundType(techType, Black); }
        }
        public static void PatchEquipables()
        {
            var Config = MyConfig.Config;

            if (Config.configEquip == Default_){ foreach (TechType techType in Equipable.techTypes) SetBackgroundType(techType, BackgroundType.Normal); }else
            if (Config.configEquip == Red_) { foreach (TechType techType in Equipable.techTypes) SetBackgroundType(techType, Red); }else
            if (Config.configEquip == Orange_) { foreach (TechType techType in Equipable.techTypes) SetBackgroundType(techType, Orange); }else
            if (Config.configEquip == Yellow_) { foreach (TechType techType in Equipable.techTypes) SetBackgroundType(techType, Yellow); }else
            if (Config.configEquip == Green_) { foreach (TechType techType in Equipable.techTypes) SetBackgroundType(techType, Green); }else
            if (Config.configEquip == Blue_) { foreach (TechType techType in Equipable.techTypes) SetBackgroundType(techType, Blue); }else
            if (Config.configEquip == LightBlue_) { foreach (TechType techType in Equipable.techTypes) SetBackgroundType(techType, LightBlue); }else
            if (Config.configEquip == Pink_) { foreach (TechType techType in Equipable.techTypes) SetBackgroundType(techType, Pink); }else
            if (Config.configEquip == Purple_) { foreach (TechType techType in Equipable.techTypes) SetBackgroundType(techType, Purple); }else
            if (Config.configEquip == White_) { foreach (TechType techType in Equipable.techTypes) SetBackgroundType(techType, White); }else
            if (Config.configEquip == Black_) { foreach (TechType techType in Equipable.techTypes) SetBackgroundType(techType, Black); }
        }
    }
}
using SMLHelper.V2.Options.Attributes;
using QModManager.API.ModLoading;
using SMLHelper.V2.Handlers;
using SMLHelper.V2.Utility;
using SMLHelper.V2.Json;
using UnityEngine;
using HarmonyLib;
using System.IO;
using System.Reflection;
using static CraftData;
using SMLHelper.V2;


namespace ItemBackgrounds_BZ
{
    [QModCore]
    public static class QMod
    {
        public static MyConfig Config { get; } = OptionsPanelHandler.RegisterModOptions<MyConfig>();
        [Menu("Item Backgrounds")]
        public class MyConfig : ConfigFile
        {
            [Choice("Tools", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes")]
            public string toolsType = "Disabled";

            [Choice("Resources", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes")]
            public string resourceType = "Disabled";

            [Choice("Land Flora (e.g. Frost Vase)", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes")]
            public string organicAir = "Disabled";

            [Choice("Underwater Flora (e.g. Table Coral)", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes")]
            public string organicWater = "Disabled";

            [Choice("Synthetics", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes")]
            public string synthtype = "Disabled";

            [Choice("Electronics", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes")]
            public string elecType = "Disabled";

            [Choice("Clothing", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes")]
            public string clothType = "Disabled";

            [Choice("Cooked Fish", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes")]
            public string cookType = "Disabled";

            [Choice("Raw Fish", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes")]
            public string rawType = "Disabled";
        }
        [QModPatch]
        public static void Load()
        {
            Config.Load();


            // Tools
            if (Config.toolsType == "Default Blue") { Tools.Colors.ApplyBlue(); }
            if (Config.toolsType == "Green") { Tools.Colors.ApplyGreen(); }
            if (Config.toolsType == "Light Purple") { Tools.Colors.ApplyLightPurple(); }
            if (Config.toolsType == "Purple") { Tools.Colors.ApplyPurple(); }
            if (Config.toolsType == "Dark Purple") { Tools.Colors.ApplyDarkPurple(); }


            // Resources
            if (Config.resourceType == "Default Blue") { Resources.Colors.ApplyBlue(); }
            if (Config.resourceType == "Green") { Resources.Colors.ApplyGreen(); }
            if (Config.resourceType == "Light Purple") { Resources.Colors.ApplyDarkPurple(); }
            if (Config.resourceType == "Purple") { Resources.Colors.ApplyDarkPurple(); }
            if (Config.resourceType == "Dark Purple") { Resources.Colors.ApplyDarkPurple(); }


            // Organic Air Plant
            if (Config.organicAir == "Default Blue") { OrganicAirPlant.Colors.ApplyBlue(); }
            if (Config.organicAir == "Green") { OrganicAirPlant.Colors.ApplyGreen(); }
            if (Config.organicAir == "Light Purple") { OrganicAirPlant.Colors.ApplyDarkPurple(); }
            if (Config.organicAir == "Purple") { OrganicAirPlant.Colors.ApplyDarkPurple(); }
            if (Config.organicAir == "Dark Purple") { OrganicAirPlant.Colors.ApplyDarkPurple(); }


            // Organic Water Plant
            if (Config.organicWater == "Default Blue") { OrganicWaterPlant.Colors.ApplyBlue(); }
            if (Config.organicWater == "Green") { OrganicWaterPlant.Colors.ApplyGreen(); }
            if (Config.organicWater == "Light Purple") { OrganicWaterPlant.Colors.ApplyDarkPurple(); }
            if (Config.organicWater == "Purple") { OrganicWaterPlant.Colors.ApplyDarkPurple(); }
            if (Config.organicWater == "Dark Purple") { OrganicWaterPlant.Colors.ApplyDarkPurple(); }


            // Synthetics
            if (Config.synthtype == "Default Blue") { Synthetic.Colors.ApplyBlue(); }
            if (Config.synthtype == "Green") { Synthetic.Colors.ApplyGreen(); }
            if (Config.synthtype == "Light Purple") { Synthetic.Colors.ApplyDarkPurple(); }
            if (Config.synthtype == "Purple") { Synthetic.Colors.ApplyDarkPurple(); }
            if (Config.synthtype == "Dark Purple") { Synthetic.Colors.ApplyDarkPurple(); }


            // Electronics
            if (Config.elecType == "Default Blue") { Electronic.Colors.ApplyBlue(); }
            if (Config.elecType == "Green") { Electronic.Colors.ApplyGreen(); }
            if (Config.elecType == "Light Purple") { Electronic.Colors.ApplyDarkPurple(); }
            if (Config.elecType == "Purple") { Electronic.Colors.ApplyDarkPurple(); }
            if (Config.elecType == "Dark Purple") { Electronic.Colors.ApplyDarkPurple(); }


            // Clothing
            if (Config.clothType == "Default Blue") { Clothing.Colors.ApplyBlue(); }
            if (Config.clothType == "Green") { Clothing.Colors.ApplyGreen(); }
            if (Config.clothType == "Light Purple") { Clothing.Colors.ApplyDarkPurple(); }
            if (Config.clothType == "Purple") { Clothing.Colors.ApplyDarkPurple(); }
            if (Config.clothType == "Dark Purple") { Clothing.Colors.ApplyDarkPurple(); }


            // Raw Fish
            if (Config.rawType == "Default Blue") { RawFish.Colors.ApplyBlue(); }
            if (Config.rawType == "Green") { RawFish.Colors.ApplyGreen(); }
            if (Config.rawType == "Light Purple") { RawFish.Colors.ApplyDarkPurple(); }
            if (Config.rawType == "Purple") { RawFish.Colors.ApplyDarkPurple(); }
            if (Config.rawType == "Dark Purple") { RawFish.Colors.ApplyDarkPurple(); }


            // Cooked Fish
            if (Config.cookType == "Default Blue") { CookedFish.Colors.ApplyBlue(); }
            if (Config.cookType == "Green") { CookedFish.Colors.ApplyGreen(); }
            if (Config.cookType == "Light Purple") { CookedFish.Colors.ApplyDarkPurple(); }
            if (Config.cookType == "Purple") { CookedFish.Colors.ApplyDarkPurple(); }
            if (Config.cookType == "Dark Purple") { CookedFish.Colors.ApplyDarkPurple(); }



        }
    }
}
    
    

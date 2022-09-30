using SMLHelper.V2.Options.Attributes;
using QModManager.API.ModLoading;
using SMLHelper.V2.Handlers;
using SMLHelper.V2.Json;
using SMLHelper.V2.Options;
using SMLHelper.V2.Utility;
using QModManager.Utility;


namespace ItemBackgrounds_BZ
{
    [QModCore]
    public static class QMod
    {
        public static MyConfig Config { get; } = OptionsPanelHandler.RegisterModOptions<MyConfig>();
        [Menu("Item Backgrounds")]
        public class MyConfig : ConfigFile
        {
            [Choice("Tools", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes"), OnChange(nameof(ToolChoiceEvent))]
            public string toolsType = "Disabled"; 

            [Choice("Resources", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes"), OnChange(nameof(ResourceChoiceEvent))]
            public string resourceType = "Disabled";

            [Choice("Land Flora (e.g. Frost Vase)", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes"), OnChange(nameof(LandChoiceEvent))]
            public string organicAir = "Disabled";

            [Choice("Underwater Flora (e.g. Table Coral)", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes"), OnChange(nameof(WaterChoiceEvent))]
            public string organicWater = "Disabled";

            [Choice("Synthetics", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes"), OnChange(nameof(ElecChoiceEvent))]
            public string synthtype = "Disabled";

            [Choice("Electronics", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes"), OnChange(nameof(SynthChoiceEvent))]
            public string elecType = "Disabled";

            [Choice("Clothing", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes"), OnChange(nameof(ClothChoiceEvent))]
            public string clothType = "Disabled";

            [Choice("Cooked Fish", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes"), OnChange(nameof(CookChoiceEvent))]
            public string cookType = "Disabled";

            [Choice("Raw Fish", new[] { "Disabled", "Default Blue", "Green", "Light Purple", "Purple", "Dark Purple" }, Tooltip = "Restart game to apply changes"), OnChange(nameof(RawChoiceEvent))]
            public string rawType = "Disabled";

            private void ToolChoiceEvent(ChoiceChangedEventArgs e)
            {
                Config.Save();
                Config.Load();

                // Tools
                if (Config.toolsType == "Default Blue") { Tools.Colors.ApplyBlue(); }
                if (Config.toolsType == "Green") { Tools.Colors.ApplyGreen(); }
                if (Config.toolsType == "Light Purple") { Tools.Colors.ApplyLightPurple(); }
                if (Config.toolsType == "Purple") { Tools.Colors.ApplyPurple(); }
                if (Config.toolsType == "Dark Purple") { Tools.Colors.ApplyDarkPurple(); }
            }
            private void ResourceChoiceEvent(ChoiceChangedEventArgs e)
            {
                Config.Save();
                Config.Load();

                // Resources
                if (Config.resourceType == "Default Blue") { Resources.Colors.ApplyBlue(); }
                if (Config.resourceType == "Green") { Resources.Colors.ApplyGreen(); }
                if (Config.resourceType == "Light Purple") { Resources.Colors.ApplyDarkPurple(); }
                if (Config.resourceType == "Purple") { Resources.Colors.ApplyDarkPurple(); }
                if (Config.resourceType == "Dark Purple") { Resources.Colors.ApplyDarkPurple(); }
            }
            private void LandChoiceEvent(ChoiceChangedEventArgs e)
            {
                Config.Save();
                Config.Load();

                // Organic Air Plant
                if (Config.organicAir == "Default Blue") { OrganicAirPlant.Colors.ApplyBlue(); }
                if (Config.organicAir == "Green") { OrganicAirPlant.Colors.ApplyGreen(); }
                if (Config.organicAir == "Light Purple") { OrganicAirPlant.Colors.ApplyDarkPurple(); }
                if (Config.organicAir == "Purple") { OrganicAirPlant.Colors.ApplyDarkPurple(); }
                if (Config.organicAir == "Dark Purple") { OrganicAirPlant.Colors.ApplyDarkPurple(); }
            }
            private void WaterChoiceEvent(ChoiceChangedEventArgs e)
            {
                Config.Save();
                Config.Load();

                // Organic Water Plant
                if (Config.organicWater == "Default Blue") { OrganicWaterPlant.Colors.ApplyBlue(); }
                if (Config.organicWater == "Green") { OrganicWaterPlant.Colors.ApplyGreen(); }
                if (Config.organicWater == "Light Purple") { OrganicWaterPlant.Colors.ApplyDarkPurple(); }
                if (Config.organicWater == "Purple") { OrganicWaterPlant.Colors.ApplyDarkPurple(); }
                if (Config.organicWater == "Dark Purple") { OrganicWaterPlant.Colors.ApplyDarkPurple(); }
            }
            private void SynthChoiceEvent(ChoiceChangedEventArgs e)
            {
                Config.Save();
                Config.Load();

                // Synthetics
                if (Config.synthtype == "Default Blue") { Synthetic.Colors.ApplyBlue(); }
                if (Config.synthtype == "Green") { Synthetic.Colors.ApplyGreen(); }
                if (Config.synthtype == "Light Purple") { Synthetic.Colors.ApplyDarkPurple(); }
                if (Config.synthtype == "Purple") { Synthetic.Colors.ApplyDarkPurple(); }
                if (Config.synthtype == "Dark Purple") { Synthetic.Colors.ApplyDarkPurple(); }
            }
            private void ElecChoiceEvent(ChoiceChangedEventArgs e)
            {
                Config.Save();
                Config.Load();

                // Electronics
                if (Config.elecType == "Default Blue") { Electronic.Colors.ApplyBlue(); }
                if (Config.elecType == "Green") { Electronic.Colors.ApplyGreen(); }
                if (Config.elecType == "Light Purple") { Electronic.Colors.ApplyDarkPurple(); }
                if (Config.elecType == "Purple") { Electronic.Colors.ApplyDarkPurple(); }
                if (Config.elecType == "Dark Purple") { Electronic.Colors.ApplyDarkPurple(); }
            }
            private void ClothChoiceEvent(ChoiceChangedEventArgs e)
            {
                Config.Save();
                Config.Load();

                // Clothing
                if (Config.clothType == "Default Blue") { Clothing.Colors.ApplyBlue(); }
                if (Config.clothType == "Green") { Clothing.Colors.ApplyGreen(); }
                if (Config.clothType == "Light Purple") { Clothing.Colors.ApplyDarkPurple(); }
                if (Config.clothType == "Purple") { Clothing.Colors.ApplyDarkPurple(); }
                if (Config.clothType == "Dark Purple") { Clothing.Colors.ApplyDarkPurple(); }
            }
            private void CookChoiceEvent(ChoiceChangedEventArgs e)
            {
                Config.Save();
                Config.Load();

                // Cooked Fish
                if (Config.cookType == "Default Blue") { CookedFish.Colors.ApplyBlue(); }
                if (Config.cookType == "Green") { CookedFish.Colors.ApplyGreen(); }
                if (Config.cookType == "Light Purple") { CookedFish.Colors.ApplyDarkPurple(); }
                if (Config.cookType == "Purple") { CookedFish.Colors.ApplyDarkPurple(); }
                if (Config.cookType == "Dark Purple") { CookedFish.Colors.ApplyDarkPurple(); }
            }
            private void RawChoiceEvent(ChoiceChangedEventArgs e)
            {
                Config.Save();
                Config.Load();

                // Raw Fish
                if (Config.rawType == "Default Blue") { RawFish.Colors.ApplyBlue(); }
                if (Config.rawType == "Green") { RawFish.Colors.ApplyGreen(); }
                if (Config.rawType == "Light Purple") { RawFish.Colors.ApplyDarkPurple(); }
                if (Config.rawType == "Purple") { RawFish.Colors.ApplyDarkPurple(); }
                if (Config.rawType == "Dark Purple") { RawFish.Colors.ApplyDarkPurple(); }
            }
        }
        [QModPatch]
        public static void Load()
        {
            Config.Load();
            Logger.Log(Logger.Level.Info, "Patching on Load");
        }
    }
}

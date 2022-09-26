using System.Reflection;
using HarmonyLib;
using QModManager.API.ModLoading;
using Logger = QModManager.Utility.Logger;

using SMLHelper.V2.Json;
using SMLHelper.V2.Options.Attributes;
using SMLHelper.V2.Handlers;

namespace RamunesRecipes_BZ
{
    [QModCore]
    public static class QMod
    {
        public static MyConfig Config { get; } = OptionsPanelHandler.RegisterModOptions<MyConfig>();

        [Menu("Ramunes Recipes")]
        public class MyConfig : ConfigFile
        {
            [Choice("Enameled Glass", new[] { "Disabled", "No Lead", "No Diamond" }, Tooltip = "Restart game to apply changes")]
            public string enameledType = "Disabled";

            [Choice("Solar Panel", new[] { "Disabled", "Enabled" }, Tooltip = "Restart game to apply changes")]
            public string solarType = "Disabled";

            [Choice("Headlamp", new[] { "Disabled", "Enabled" }, Tooltip = "Restart game to apply changes")]
            public string headlampType = "Disabled";

            [Choice("Battery", new[] { "Disabled", "Enabled" }, Tooltip = "Restart game to apply changes")]
            public string batteryType = "Disabled";
        }
        [QModPatch]
        public static void Load()
        {
            Config.Load();

            if (QMod.Config.enameledType == "No Diamond")
            { RamunesRecipes.Recipes.ApplyEnameledA(); }

            if (QMod.Config.enameledType == "No Lead")
            { RamunesRecipes.Recipes.ApplyEnameledB(); }

            if (QMod.Config.solarType == "Enabled")
            { RamunesRecipes.Recipes.ApplySolar(); }

            if (QMod.Config.headlampType == "Enabled")
            {RamunesRecipes.Recipes.ApplyHelmet();}


            if (QMod.Config.batteryType == "Enabled")
            { RamunesRecipes.Recipes.ApplyBattery(); }
        }
    }
}
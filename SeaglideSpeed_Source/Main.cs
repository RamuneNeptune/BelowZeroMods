using System.Reflection;
using HarmonyLib;
using QModManager.API.ModLoading;
using Logger = QModManager.Utility.Logger;
using UnityEngine;

using SMLHelper.V2.Json;
using SMLHelper.V2.Options.Attributes;
using SMLHelper.V2.Handlers;


namespace SeaglideSpeed_BZ
{
    [QModCore]
    public static class QMod
    {
        internal static Config Config { get; private set; }

        [QModPatch]
        public static void Patch()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var modName = ($"RamuneNeptune_{assembly.GetName().Name}");
            Harmony harmony = new Harmony(modName);
            harmony.PatchAll(assembly);

            Config = OptionsPanelHandler.Main.RegisterModOptions<Config>();
            Logger.Log(Logger.Level.Info, "Patched successfully!", null, true);
        }
    }

    [Menu("Airbladder Capacity BZ")]
    public class Config : ConfigFile
    {
        [Slider("Seaglide Speed", Format = "{0:F2}", Min = 25.0F, Max = 100.0F, DefaultValue = 25.0F, Step = 1.0F, Tooltip = "Re-select Seaglide to update")]
        public float speedVal = 25.0F;
        [Slider("Seaglide Acceleration", Format = "{0:F2}", Min = 36.56F, Max = 75.0F, DefaultValue = 36.56F, Step = 1.0F, Tooltip = "Re-select Seaglide to update")]
        public float accelVal = 36.56F;
    }
}
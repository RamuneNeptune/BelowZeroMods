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
        }
    }

    [Menu("SeaglideSpeed_BZ")]
    public class Config : ConfigFile
    {
        [Slider("Seaglide Speed (Default = 0)", Format = "{0:F2}", Min = 0.0F, Max = 1.0F, DefaultValue = 0.0F, Step = 0.1F, Tooltip = "Re-equip to apply changes")]
        public float accelVal = 0.0F;
    }
}
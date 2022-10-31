
using System.Reflection;
using HarmonyLib;
using QModManager.API.ModLoading;
using Logger = QModManager.Utility.Logger;
using UnityEngine;

using SMLHelper.V2.Json;
using SMLHelper.V2.Options.Attributes;
using SMLHelper.V2.Handlers;



namespace Unnamed
{
    [QModCore]
    public static class MainPatch
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

    [Menu("<b>P  R  A  W  N</b>")]
    public class Config : ConfigFile
    {
        [Slider("Width (x)", Format = "{0:F2}", Min = 1F, Max = 50f, DefaultValue = 1.0f, Step = 1f, Tooltip = "Re-enter the exosuit to update")]
        public float width = 1f;

        [Slider("Height (y)", Format = "{0:F2}", Min = 1F, Max = 50f, DefaultValue = 1.0f, Step = 1f, Tooltip = "Re-enter the exosuit to update")]
        public float height = 1f;

        [Slider("Length (z)", Format = "{0:F2}", Min = 1F, Max = 50f, DefaultValue = 1.0f, Step = 1f, Tooltip = "Re-enter the exosuit to update")]
        public float length = 1f;

        [Toggle("Enable value logging", Tooltip = "Displays text on screen showing the new values of the exosuit scale, also lets you know if the exosuit has been updated.")]
        public bool logging = false;
    }
}
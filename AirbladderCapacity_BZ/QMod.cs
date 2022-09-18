﻿using System.Reflection;
using HarmonyLib;
using QModManager.API.ModLoading;
using Logger = QModManager.Utility.Logger;

using SMLHelper.V2.Json;
using SMLHelper.V2.Options.Attributes;
using SMLHelper.V2.Handlers;


namespace AirbladderCapacity_BZ
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
    [Slider("Oxygen Capacity (amount)", Format = "{0:F2}", Min = 5.0F, Max = 225.0F, DefaultValue = 5.0F, Step = 1F)]
    public float oxygenCap = 5.0F;
  }
}
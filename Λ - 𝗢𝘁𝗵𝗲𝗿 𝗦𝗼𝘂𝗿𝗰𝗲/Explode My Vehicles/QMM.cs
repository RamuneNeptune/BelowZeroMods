

using QModManager.API.ModLoading;
using System.Reflection;
using HarmonyLib;
using SMLHelper.V2.Handlers;
using SMLHelper.V2.Options.Attributes;
using SMLHelper.V2.Json;
using UnityEngine;
using Logger = QModManager.Utility.Logger;

namespace ExplodeMyVehicles_BZ
{
    [QModCore]
    public static class QMM
    {
        [QModPatch]
        public static void Patch()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var modName = ($"RamuneNeptune_{assembly.GetName().Name}");
            Harmony harmony = new Harmony(modName);
            harmony.PatchAll(assembly);
        }
    }
}
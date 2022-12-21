

using Logger = QModManager.Utility.Logger;
using UnityEngine;
using HarmonyLib;

namespace ExplodeMyVehicles_BZ
{
    [HarmonyPatch(typeof(Exosuit))]
    public class ExosuitPatches
    {
        [HarmonyPatch(nameof(Exosuit.Awake))]
        [HarmonyPostfix]

        public static void ExosuitAwakePatch(Exosuit __instance)
        {
            GameObject exosuit = GameObject.Find("Exosuit(Clone)");
            exosuit.EnsureComponent<ExplodeComponent>();
            Logger.Log(Logger.Level.Info, "<b>Attached to Exosuit - Ready to explode on your command!</b>\n", null, true);

            GameObject seatruck = GameObject.Find("SeaTruck(Clone)");
            seatruck.EnsureComponent<ExplodeComponent>();
            Logger.Log(Logger.Level.Info, "<b>Attached to Seatruck - Ready to explode on your command!</b>\n", null, true);
        }
    }
}
using HarmonyLib;
using Logger = QModManager.Utility.Logger;

namespace AirbladderCapacity_BZ
{
    class AirbladderCapacity
    {
        [HarmonyPatch(typeof(PlayerTool))]
        [HarmonyPatch("Awake")]
        internal class PatchPlayerToolAwake
        {
            [HarmonyPostfix]
            public static void Postfix(PlayerTool __instance)
            {
                if (__instance.GetType() == typeof(AirBladder))
                {
                    AirBladder airbladder = __instance as AirBladder;

                    float oxygenModifier = QMod.Config.oxygenCap;
                    airbladder.oxygenCapacity = oxygenModifier;

                    Logger.Log(Logger.Level.Info, $"Modified oxygen = {oxygenModifier}", null, true);
                }
            }
        }
    }
}
using HarmonyLib;
using Logger = QModManager.Utility.Logger;

namespace AirbladderCapacity_BZ
{
    class AirbladderCapacity
    {
        [HarmonyPatch(typeof(AirBladder))]
        [HarmonyPatch("AddOxygen")]
        internal class PatchAirBladderAddOxygen
        {
            [HarmonyPostfix]
            public static void Postfix(AirBladder __instance)
            {
                if (__instance.GetType() == typeof(AirBladder))
                {
                    AirBladder airbladder = __instance as AirBladder;
                    float oxygenModifier = QMod.Config.oxygenCap;

                    if (airbladder.oxygen != oxygenModifier)
                    {
                        airbladder.oxygen = oxygenModifier;
                    }
                }
            }
        }
    }
}
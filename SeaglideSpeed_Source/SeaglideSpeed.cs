using HarmonyLib;
using Logger = QModManager.Utility.Logger;
using UnityEngine;

namespace SeaglideSpeed_BZ
{
    class SeaglideSpeed
    {
        [HarmonyPatch(typeof(PlayerController))]
        [HarmonyPatch("Start")]
        internal class PatchPlayerControllerStart
        {
            [HarmonyPostfix]
            public static void Postfix(PlayerController __instance)
            {
                PlayerController playercontroller = __instance as PlayerController;
                float fwdMaxSpeed = QMod.Config.speedVal;
                float seaglideAcl = QMod.Config.accelVal;
                playercontroller.seaglideForwardMaxSpeed = fwdMaxSpeed;
                playercontroller.seaglideWaterAcceleration = seaglideAcl;
            }
        }
    }
}
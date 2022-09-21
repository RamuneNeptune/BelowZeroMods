using HarmonyLib;
using UnityEngine;
using Logger = QModManager.Utility.Logger;

namespace SeaglideSpeed_BZ
{
    [HarmonyPatch(typeof(PlayerController))]
    public static class PlayerControllerPatches
    {
        [HarmonyPatch(nameof(SetMotorMode)), HarmonyPrefix]
        public static void SetMotorMode(Player.MotorMode newMotorMode, PlayerController __instance)
        {
            if (newMotorMode != Player.MotorMode.Seaglide)
            {
                return;
            }
            __instance.seaglideForwardMaxSpeed = Mathf.Lerp(20.0f, 30.00f, QMod.Config.accelVal);
            __instance.seaglideWaterAcceleration = Mathf.Lerp(28.56f, 56.00f, QMod.Config.accelVal);
        }
    }
}
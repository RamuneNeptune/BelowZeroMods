

using Logger = QModManager.Utility.Logger;
using UnityEngine;
using HarmonyLib;
using System.Threading.Tasks;

namespace DebugHotkeysBZ
{
    [HarmonyPatch(typeof(Player))]
    public static class PlayerPatches
    {
        [HarmonyPatch(nameof(Player.Update))]
        [HarmonyPostfix]
        public static void Player_Update_Postfix(Player __instance)
        {
            if (Input.GetKeyDown(QMM.Config.LogHotkeys))
            {
                Logger.Log(Logger.Level.Info,
                    $"<color=#007EC2>{QMM.Config.LogHotkeys} -</color> display hotkeys\n" +
                    $"<color=#007EC2>{QMM.Config.CommandGhost} -</color> ghost \n" +
                    $"<color=#007EC2>{QMM.Config.CommandWarpForward} -</color> warpforward 1 \n" +
                    $"<color=#007EC2>{QMM.Config.CommandSpeed} -</color> speed 1\n" +
                    $"<color=#007EC2>{QMM.Config.CommandSpeedHalf} -</color> speed 0.5 \n" +
                    $"<color=#007EC2>{QMM.Config.CommandFog} -</color> fog \n" +
                    $"<color=#007EC2>{QMM.Config.CommandSetDay} -</color> day \n" +
                    $"<color=#007EC2>{QMM.Config.CommandSetNight} -</color> night",
                    null, true);
            }

            if (Input.GetKeyDown(QMM.Config.CommandGhost))
            {
                DevConsole.SendConsoleCommand("ghost");
                Logger.Log(Logger.Level.Info, "<color=#AFEDFA>Toggled 'ghost' command</color>", null, true);
            }

            if (Input.GetKeyDown(QMM.Config.CommandWarpForward))
            {
                DevConsole.SendConsoleCommand("warpforward 1");
                Logger.Log(Logger.Level.Info, "<color=#AFEDFA>Sent 'warpforward 1' command</color>", null, true);
            }

            if (Input.GetKeyDown(QMM.Config.CommandSpeed))
            {
                DevConsole.SendConsoleCommand("speed 1");
            }

            if (Input.GetKeyDown(QMM.Config.CommandSpeedHalf))
            {
                DevConsole.SendConsoleCommand("speed 0.5");
            }
            
            if (Input.GetKeyDown(QMM.Config.CommandFog))
            {
                DevConsole.SendConsoleCommand("fog");
                Logger.Log(Logger.Level.Info, "<color=#AFEDFA>Sent 'fog' command</color>", null, true);
            }
            
            if (Input.GetKeyDown(QMM.Config.CommandSetDay))
            {
                DevConsole.SendConsoleCommand("day");
                Logger.Log(Logger.Level.Info, "<color=#AFEDFA>Set time to day</color>", null, true);
            }

            if (Input.GetKeyDown(QMM.Config.CommandSetNight))
            {
                DevConsole.SendConsoleCommand("night");
                Logger.Log(Logger.Level.Info, "<color=#AFEDFA>Set time to night</color>", null, true);
            }
        }
    }
}
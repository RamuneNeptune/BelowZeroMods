

using QModManager.API.ModLoading;
using System.Reflection;
using HarmonyLib;
using SMLHelper.V2.Handlers;
using SMLHelper.V2.Options.Attributes;
using SMLHelper.V2.Json;
using UnityEngine;

namespace DebugHotkeysBZ
{
    [QModCore]
    public static class QMM
    {
        public static MyConfig Config { get; } = OptionsPanelHandler.RegisterModOptions<MyConfig>();

        [QModPatch]
        public static void Patch()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var modName = ($"KentuckyFriedWaffle_{assembly.GetName().Name}");
            Harmony harmony = new Harmony(modName);
            harmony.PatchAll(assembly);
        }
    }
    [Menu("Command Hotkeys BZ")]
    public class MyConfig : ConfigFile
    {
        [Keybind("Display Hotkeys", Tooltip = "Keybind used to display hotkeys while in game")]
        public KeyCode LogHotkeys = KeyCode.Comma;

        [Keybind("<color=#AFEDFA>ghost</color>")]
        public KeyCode CommandGhost = KeyCode.F2;

        [Keybind("<color=#AFEDFA>warpforward 1</color>")]
        public KeyCode CommandWarpForward = KeyCode.F4;
        
        [Keybind("<color=#AFEDFA>timescale 1</color>")]
        public KeyCode CommandSpeed = KeyCode.F5;
        
        [Keybind("<color=#AFEDFA>timescale 0.5</color>")]
        public KeyCode CommandSpeedHalf = KeyCode.F6;

        [Keybind("<color=#AFEDFA>fog</color>")]
        public KeyCode CommandFog = KeyCode.F7;

        [Keybind("<color=#AFEDFA>day</color>")]
        public KeyCode CommandSetDay = KeyCode.F9;

        [Keybind("<color=#AFEDFA>night</color>")]
        public KeyCode CommandSetNight = KeyCode.F10;
    }
}
using QModManager.API.ModLoading;
using System.Reflection;
using HarmonyLib;
using SMLHelper.V2.Handlers;
using SMLHelper.V2.Options.Attributes;
using SMLHelper.V2.Json;
using UnityEngine;
using Logger = QModManager.Utility.Logger;


namespace AchievementUnlocker_BZ
{
    [QModCore]
    public static class QMM
    {
        public static MyConfig Config { get; } = OptionsPanelHandler.RegisterModOptions<MyConfig>();

        [QModPatch]
        public static void Patch()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var modName = ($"RamuneNeptune_{assembly.GetName().Name}");
            Harmony harmony = new Harmony(modName);
            harmony.PatchAll(assembly);
        }
    }

    [Menu("Achievement Unlocker")]
    public class MyConfig : ConfigFile
    {
        // DROP POD
        [Button("Locate your Drop Pod")]
        public void droppod()
        {
            PlatformUtils.main.GetServices().UnlockAchievement(GameAchievements.Id.droppod);
            Logger.Log(Logger.Level.Info, $"<b><b><color=#0074CC>Achievement Unlocked:</color></b></b> Locate your Drop Pod", null, true);
        }

        // SEATRUCK
        [Button("Construct a Seatruck")]
        public void seatruck()
        {
            PlatformUtils.main.GetServices().UnlockAchievement(GameAchievements.Id.seatruck);
            Logger.Log(Logger.Level.Info, $"<b><color=#0074CC>Achievement Unlocked:</color></b> Construct a Seatruck", null, true);
        }

        // SNOWFOX
        [Button("Ride a Snowfox")]
        public void snowfox()
        {
            PlatformUtils.main.GetServices().UnlockAchievement(GameAchievements.Id.snowfox);
            Logger.Log(Logger.Level.Info, $"<b><color=#0074CC>Achievement Unlocked:</color></b> Ride a Snowfox", null, true);
        }

        // COLD SUIT
        [Button("Construct a Cold Suit")]
        public void coldsuit()
        {
            PlatformUtils.main.GetServices().UnlockAchievement(GameAchievements.Id.coldsuit);
            Logger.Log(Logger.Level.Info, $"<b><color=#0074CC>Achievement Unlocked:</color></b> Construct a Cold Suit", null, true);
        }

        // SPY PENGLING
        [Button("Construct a Spy Pengling")]
        public void spypengling()
        {
            PlatformUtils.main.GetServices().UnlockAchievement(GameAchievements.Id.spypengling);
            Logger.Log(Logger.Level.Info, $"<b><color=#0074CC>Achievement Unlocked:</color></b> Construct a Spy Pengling", null, true);
        }

        // JUKEBOX
        [Button("Install a Jukebox")]
        public void jukebox()
        {
            PlatformUtils.main.GetServices().UnlockAchievement(GameAchievements.Id.jukebox);
            Logger.Log(Logger.Level.Info, $"<b><color=#0074CC>Achievement Unlocked:</color></b> Install a Jukebox", null, true);
        }

        // BRIDGE
        [Button("Repair the Bridge")]
        public void bridge()
        {
            PlatformUtils.main.GetServices().UnlockAchievement(GameAchievements.Id.bridge);
            Logger.Log(Logger.Level.Info, $"<b><color=#0074CC>Achievement Unlocked:</color></b> Repair the Bridge", null, true);
        }

        // MARG
        [Button("Find Marguerit's home")]
        public void marg()
        {
            PlatformUtils.main.GetServices().UnlockAchievement(GameAchievements.Id.marg);
            Logger.Log(Logger.Level.Info, $"<b><color=#0074CC>Achievement Unlocked:</color></b> Find Marguerit's Home", null, true);
        }

        // RADIO TOWER
        [Button("Disable Alterra communications")]
        public void radiotower()
        {
            PlatformUtils.main.GetServices().UnlockAchievement(GameAchievements.Id.radiotower);
            Logger.Log(Logger.Level.Info, $"<b><color=#0074CC>Achievement Unlocked:</color></b> Disable Alterra communications", null, true);
        }

        // FROLO?
        [Button("Use the Antidote")]
        public void frolo()
        {
            PlatformUtils.main.GetServices().UnlockAchievement(GameAchievements.Id.frolo);
            Logger.Log(Logger.Level.Info, $"<b><color=#0074CC>Achievement Unlocked:</color></b> Use the Antidote", null, true);
        }

        // AL-AN BODY
        [Button("Construct an Alien Vessel")]
        public void body()
        {
            PlatformUtils.main.GetServices().UnlockAchievement(GameAchievements.Id.body);
            Logger.Log(Logger.Level.Info, $"<b><color=#0074CC>Achievement Unlocked:</color></b> Construct an Alien Vessel", null, true);
        }

        // ENDING
        [Button("Leave 4546b")]
        public void ending()
        {
            PlatformUtils.main.GetServices().UnlockAchievement(GameAchievements.Id.ending);
            Logger.Log(Logger.Level.Info, $"<b><color=#0074CC>Achievement Unlocked:</color></b> Leave 4546b", null, true);
        }
    }
}
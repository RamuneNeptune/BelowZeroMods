using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using JetBrains.Annotations;
using SMLHelper.V2.Crafting;
using SMLHelper.V2.Handlers;
using SMLHelper.V2.Json;
using SMLHelper.V2.Utility;
using Logger = QModManager.Utility.Logger;
using UnityEngine;
using static CraftData;
using static GameInput;

namespace Unnamed
{
    [HarmonyPatch(typeof(Exosuit))]
    [HarmonyPatch("OnPlayerEntered")]
    internal class Exosuit_Start_Patch
    {
        [HarmonyPostfix]
        public static void Postfix(Exosuit __instance)
        {
            var width = MainPatch.Config.width;
            var height = MainPatch.Config.height;
            var length = MainPatch.Config.length;

            var scale = "Width: " + width + ", Height: " + height + ", Length: " + length;
            
            __instance.transform.localScale = new Vector3(width, height, length);

            if (MainPatch.Config.logging)
            {
                Logger.Log(Logger.Level.Info, $"Exosuit updated, new scale:", null, true);
                Logger.Log(Logger.Level.Info, $"{scale}", null, true);
            }
        }
    }
}
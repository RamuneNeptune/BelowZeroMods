using SMLHelper.V2.Options.Attributes;
using QModManager.API.ModLoading;
using SMLHelper.V2.Handlers;
using SMLHelper.V2.Utility;
using SMLHelper.V2.Json;
using UnityEngine;
using HarmonyLib;
using System.IO;
using System.Reflection;
using static CraftData;
using SMLHelper.V2;

namespace CookedFish
{
    public static class Colors
    {
        public static void ApplyBlue()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedArcticPeeper, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedArrowRay, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedBladderfish, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedBoomerang, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedDiscusFish, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedFeatherFish, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedFeatherFishRed, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedHoopfish, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedNootFish, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedSpinefish, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedSpinnerfish, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedSymbiote, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedTriops, CraftData.BackgroundType.Normal);
        }
        public static void ApplyGreen()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedArcticPeeper, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedArrowRay, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedBladderfish, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedBoomerang, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedDiscusFish, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedFeatherFish, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedFeatherFishRed, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedHoopfish, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedNootFish, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedSpinefish, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedSpinnerfish, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedSymbiote, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedTriops, CraftData.BackgroundType.PlantAir);

        }
        public static void ApplyLightPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedArcticPeeper, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedArrowRay, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedBladderfish, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedBoomerang, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedDiscusFish, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedFeatherFish, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedFeatherFishRed, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedHoopfish, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedNootFish, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedSpinefish, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedSpinnerfish, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedSymbiote, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedTriops, CraftData.BackgroundType.PlantWater);
        }
        public static void ApplyPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedArcticPeeper, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedArrowRay, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedBladderfish, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedBoomerang, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedDiscusFish, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedFeatherFish, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedFeatherFishRed, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedHoopfish, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedNootFish, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedSpinefish, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedSpinnerfish, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedSymbiote, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedTriops, CraftData.BackgroundType.ExosuitArm);
        }
        public static void ApplyDarkPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedArcticPeeper, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedArrowRay, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedBladderfish, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedBoomerang, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedDiscusFish, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedFeatherFish, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedFeatherFishRed, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedHoopfish, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedNootFish, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedSpinefish, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedSpinnerfish, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedSymbiote, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.CookedTriops, CraftData.BackgroundType.Blueprint);
        }
    }
}
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

namespace OrganicWaterPlant
{
    public static class Colors
    {
        public static void ApplyBlue()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.SmallMaroonPlantSeed, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.TwistyBridgesMushroomChunk, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.CreepvineSeedCluster, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.JellyPlant, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.JellyPlantSeed, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.RedBushSeed, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericRibbonSeed, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericRibbon, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericSpiral, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericSpiralChunk, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.PurpleStalkSeed, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.DeepLilyShroom, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.KelpRootPustule, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.CreepvinePiece, CraftData.BackgroundType.Normal);
        }
        public static void ApplyGreen()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.SmallMaroonPlantSeed, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.TwistyBridgesMushroomChunk, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.CreepvineSeedCluster, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.JellyPlant, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.JellyPlantSeed, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.RedBushSeed, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericRibbonSeed, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericRibbon, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericSpiral, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericSpiralChunk, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.PurpleStalkSeed, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.DeepLilyShroom, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.KelpRootPustule, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.CreepvinePiece, CraftData.BackgroundType.PlantAir);
        }
        public static void ApplyLightPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.SmallMaroonPlantSeed, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.TwistyBridgesMushroomChunk, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.CreepvineSeedCluster, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.JellyPlant, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.JellyPlantSeed, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.RedBushSeed, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericRibbonSeed, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericRibbon, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericSpiral, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericSpiralChunk, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.PurpleStalkSeed, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.DeepLilyShroom, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.KelpRootPustule, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.CreepvinePiece, CraftData.BackgroundType.PlantWater);
        }
        public static void ApplyPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.SmallMaroonPlantSeed, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.TwistyBridgesMushroomChunk, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.CreepvineSeedCluster, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.JellyPlant, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.JellyPlantSeed, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.RedBushSeed, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericRibbonSeed, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericRibbon, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericSpiral, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericSpiralChunk, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.PurpleStalkSeed, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.DeepLilyShroom, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.KelpRootPustule, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.CreepvinePiece, CraftData.BackgroundType.ExosuitArm);
        }
        public static void ApplyDarkPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.SmallMaroonPlantSeed, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.TwistyBridgesMushroomChunk, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.CreepvineSeedCluster, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.JellyPlant, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.JellyPlantSeed, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.RedBushSeed, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericRibbonSeed, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericRibbon, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericSpiral, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.GenericSpiralChunk, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.PurpleStalkSeed, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.DeepLilyShroom, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.KelpRootPustule, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.CreepvinePiece, CraftData.BackgroundType.Blueprint);
        }
    }
}
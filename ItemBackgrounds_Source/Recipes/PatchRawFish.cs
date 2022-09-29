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

namespace RawFish
{
    public static class Colors
    {
        public static void ApplyBlue()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.ArcticPeeper, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.ArrowRay, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Bladderfish, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Boomerang, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.DiscusFish, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.FeatherFish, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.FeatherFishRed, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Hoopfish, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.NootFish, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Spinefish, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.SpinnerFish, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Symbiote, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Triops, CraftData.BackgroundType.Normal);
        }
        public static void ApplyGreen()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.ArcticPeeper, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.ArrowRay, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Bladderfish, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Boomerang, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.DiscusFish, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.FeatherFish, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.FeatherFishRed, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Hoopfish, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.NootFish, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Spinefish, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.SpinnerFish, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Symbiote, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Triops, CraftData.BackgroundType.PlantAir);
        }
        public static void ApplyLightPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.ArcticPeeper, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.ArrowRay, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Bladderfish, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Boomerang, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.DiscusFish, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.FeatherFish, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.FeatherFishRed, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Hoopfish, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.NootFish, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Spinefish, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.SpinnerFish, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Symbiote, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Triops, CraftData.BackgroundType.PlantWater);
        }
        public static void ApplyPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.ArcticPeeper, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.ArrowRay, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Bladderfish, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Boomerang, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.DiscusFish, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.FeatherFish, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.FeatherFishRed, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Hoopfish, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.NootFish, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Spinefish, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.SpinnerFish, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Symbiote, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Triops, CraftData.BackgroundType.ExosuitArm);
        }
        public static void ApplyDarkPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.ArcticPeeper, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.ArrowRay, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Bladderfish, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Boomerang, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.DiscusFish, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.FeatherFish, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.FeatherFishRed, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Hoopfish, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.NootFish, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Spinefish, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.SpinnerFish, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Symbiote, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Triops, CraftData.BackgroundType.Blueprint);
        }
    }
}
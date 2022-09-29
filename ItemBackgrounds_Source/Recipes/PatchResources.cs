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

namespace Resources
{
    public static class Colors
    {
        public static void ApplyBlue()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.Copper, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Sulphur, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Diamond, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Gold, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Kyanite, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Lead, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Lithium, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Magnetite, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.ScrapMetal, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Nickel, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Quartz, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.AluminumOxide, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Salt, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Silver, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Titanium, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.UraniniteCrystal, CraftData.BackgroundType.Normal);
        }
        public static void ApplyGreen()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.Copper, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Sulphur, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Diamond, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Gold, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Kyanite, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Lead, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Lithium, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Magnetite, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.ScrapMetal, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Nickel, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Quartz, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.AluminumOxide, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Salt, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Silver, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Titanium, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.UraniniteCrystal, CraftData.BackgroundType.PlantAir);
        }
        public static void ApplyLightPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.Copper, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Sulphur, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Diamond, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Gold, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Kyanite, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Lead, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Lithium, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Magnetite, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.ScrapMetal, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Nickel, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Quartz, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.AluminumOxide, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Salt, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Silver, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Titanium, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.UraniniteCrystal, CraftData.BackgroundType.PlantWater);
        }
        public static void ApplyPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.Copper, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Sulphur, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Diamond, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Gold, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Kyanite, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Lead, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Lithium, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Magnetite, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.ScrapMetal, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Nickel, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Quartz, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.AluminumOxide, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Salt, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Silver, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Titanium, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.UraniniteCrystal, CraftData.BackgroundType.ExosuitArm);
        }
        public static void ApplyDarkPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.Copper, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Sulphur, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Diamond, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Gold, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Kyanite, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Lead, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Lithium, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Magnetite, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.ScrapMetal, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Nickel, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Quartz, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.AluminumOxide, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Salt, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Silver, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Titanium, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.UraniniteCrystal, CraftData.BackgroundType.Blueprint);
        }
    }
}
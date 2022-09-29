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

namespace Clothing
{
    public static class Colors
    {
        public static void ApplyBlue()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.SuitBoosterTank, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.FlashlightHelmet, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.ColdSuit, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.ColdSuitGloves, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.ColdSuitHelmet, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Fins, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.SwimChargeFins, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.UltraGlideFins, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Tank, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.DoubleTank, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.HighCapacityTank, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.PlasteelTank, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.SuitBoosterTank, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Rebreather, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.ReinforcedDiveSuit, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.ReinforcedGloves, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.WaterFiltrationSuit, CraftData.BackgroundType.Normal);
        }
        public static void ApplyGreen()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.SuitBoosterTank, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.FlashlightHelmet, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.ColdSuit, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.ColdSuitGloves, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.ColdSuitHelmet, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Fins, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.SwimChargeFins, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.UltraGlideFins, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Tank, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.DoubleTank, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.HighCapacityTank, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.PlasteelTank, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.SuitBoosterTank, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Rebreather, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.ReinforcedDiveSuit, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.ReinforcedGloves, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.WaterFiltrationSuit, CraftData.BackgroundType.PlantAir);
        }
        public static void ApplyLightPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.SuitBoosterTank, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.FlashlightHelmet, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.ColdSuit, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.ColdSuitGloves, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.ColdSuitHelmet, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Fins, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.SwimChargeFins, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.UltraGlideFins, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Tank, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.DoubleTank, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.HighCapacityTank, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.PlasteelTank, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.SuitBoosterTank, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Rebreather, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.ReinforcedDiveSuit, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.ReinforcedGloves, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.WaterFiltrationSuit, CraftData.BackgroundType.PlantWater);
        }
        public static void ApplyPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.SuitBoosterTank, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.FlashlightHelmet, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.ColdSuit, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.ColdSuitGloves, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.ColdSuitHelmet, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Fins, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.SwimChargeFins, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.UltraGlideFins, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Tank, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.DoubleTank, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.HighCapacityTank, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.PlasteelTank, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.SuitBoosterTank, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Rebreather, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.ReinforcedDiveSuit, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.ReinforcedGloves, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.WaterFiltrationSuit, CraftData.BackgroundType.ExosuitArm);
        }
        public static void ApplyDarkPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.SuitBoosterTank, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.FlashlightHelmet, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.ColdSuit, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.ColdSuitGloves, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.ColdSuitHelmet, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Fins, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.SwimChargeFins, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.UltraGlideFins, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Tank, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.DoubleTank, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.HighCapacityTank, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.PlasteelTank, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.SuitBoosterTank, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Rebreather, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.ReinforcedDiveSuit, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.ReinforcedGloves, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.WaterFiltrationSuit, CraftData.BackgroundType.Blueprint);
        }
    }
}
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

namespace Electronic
{
    public static class Colors
    {
        public static void ApplyBlue()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.AdvancedWiringKit, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Battery, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.ComputerChip, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.CopperWire, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.PrecursorIonBattery, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.PrecursorIonPowerCell, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.RadioTowerPPU, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.PowerCell, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.ReactorRod, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.RadioTowerTOM, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.WiringKit, CraftData.BackgroundType.Normal);
        }
        public static void ApplyGreen()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.AdvancedWiringKit, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Battery, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.ComputerChip, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.CopperWire, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.PrecursorIonBattery, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.PrecursorIonPowerCell, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.RadioTowerPPU, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.PowerCell, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.ReactorRod, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.RadioTowerTOM, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.WiringKit, CraftData.BackgroundType.PlantAir);
        }
        public static void ApplyLightPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.AdvancedWiringKit, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Battery, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.ComputerChip, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.CopperWire, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.PrecursorIonBattery, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.PrecursorIonPowerCell, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.RadioTowerPPU, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.PowerCell, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.ReactorRod, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.RadioTowerTOM, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.WiringKit, CraftData.BackgroundType.PlantWater);
        }
        public static void ApplyPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.AdvancedWiringKit, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Battery, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.ComputerChip, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.CopperWire, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.PrecursorIonBattery, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.PrecursorIonPowerCell, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.RadioTowerPPU, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.PowerCell, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.ReactorRod, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.RadioTowerTOM, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.WiringKit, CraftData.BackgroundType.ExosuitArm);
        }
        public static void ApplyDarkPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.AdvancedWiringKit, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Battery, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.ComputerChip, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.CopperWire, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.PrecursorIonBattery, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.PrecursorIonPowerCell, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.RadioTowerPPU, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.PowerCell, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.ReactorRod, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.RadioTowerTOM, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.WiringKit, CraftData.BackgroundType.Blueprint);
        }
    }
}
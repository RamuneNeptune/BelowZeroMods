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

namespace Synthetic
{
    public static class Colors
    {
        public static void ApplyBlue()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.EnameledGlass, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Glass, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.FiberMesh, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Lubricant, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.PlasteelIngot, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Silicone, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.TitaniumIngot, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Aerogel, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.FrozenCreatureAntidote, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Benzene, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.HydraulicFluid, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.HydrochloricAcid, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Benzene, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.Polyaniline, CraftData.BackgroundType.Normal);
            CraftDataHandler.Main.SetBackgroundType(TechType.AramidFibers, CraftData.BackgroundType.Normal);
        }
        public static void ApplyGreen()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.EnameledGlass, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Glass, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.FiberMesh, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Lubricant, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.PlasteelIngot, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Silicone, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.TitaniumIngot, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Aerogel, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.FrozenCreatureAntidote, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Benzene, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.HydraulicFluid, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.HydrochloricAcid, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Benzene, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.Polyaniline, CraftData.BackgroundType.PlantAir);
            CraftDataHandler.Main.SetBackgroundType(TechType.AramidFibers, CraftData.BackgroundType.PlantAir);

        }
        public static void ApplyLightPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.EnameledGlass, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Glass, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.FiberMesh, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Lubricant, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.PlasteelIngot, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Silicone, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.TitaniumIngot, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Aerogel, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.FrozenCreatureAntidote, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Benzene, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.HydraulicFluid, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.HydrochloricAcid, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Benzene, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.Polyaniline, CraftData.BackgroundType.PlantWater);
            CraftDataHandler.Main.SetBackgroundType(TechType.AramidFibers, CraftData.BackgroundType.PlantWater);
        }
        public static void ApplyPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.EnameledGlass, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Glass, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.FiberMesh, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Lubricant, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.PlasteelIngot, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Silicone, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.TitaniumIngot, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Aerogel, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.FrozenCreatureAntidote, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Benzene, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.HydraulicFluid, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.HydrochloricAcid, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Benzene, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.Polyaniline, CraftData.BackgroundType.ExosuitArm);
            CraftDataHandler.Main.SetBackgroundType(TechType.AramidFibers, CraftData.BackgroundType.ExosuitArm);
        }
        public static void ApplyDarkPurple()
        {
            CraftDataHandler.Main.SetBackgroundType(TechType.EnameledGlass, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Glass, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.FiberMesh, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Lubricant, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.PlasteelIngot, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Silicone, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.TitaniumIngot, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Aerogel, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.FrozenCreatureAntidote, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Benzene, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.HydraulicFluid, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.HydrochloricAcid, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Benzene, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.Polyaniline, CraftData.BackgroundType.Blueprint);
            CraftDataHandler.Main.SetBackgroundType(TechType.AramidFibers, CraftData.BackgroundType.Blueprint);
        }
    }
}

using Logger = QModManager.Utility.Logger;
using QModManager.API.ModLoading;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;

using SMLHelper.V2.Json;
using SMLHelper.V2.Options.Attributes;
using SMLHelper.V2.Handlers;
using SMLHelper.V2.Crafting;
using RamunesRecipes_BZ;

namespace RamunesRecipes
{
    public static class Recipes
    {
public static void ApplyEnameledA()
{
var enameledGlassA = new RecipeData(){
craftAmount = 1, Ingredients = {
new Ingredient(TechType.Glass, 1),
new Ingredient(TechType.Lead, 1),
new Ingredient(TechType.Titanium, 2),}};
CraftDataHandler.SetTechData(TechType.EnameledGlass, enameledGlassA);
}

public static void ApplyEnameledB()
{
var enameledGlassB = new RecipeData(){
craftAmount = 1, Ingredients = {
new Ingredient(TechType.Glass, 1),
new Ingredient(TechType.Diamond, 1),
new Ingredient(TechType.Titanium, 2),}};
CraftDataHandler.SetTechData(TechType.EnameledGlass, enameledGlassB);
}
    
        
//////// DIVIDER ////////


public static void ApplyHelmet()
{
var flashlightHelmet = new RecipeData(){
craftAmount = 1, Ingredients = {
new Ingredient(TechType.Battery, 2),
new Ingredient(TechType.Glass, 1),
new Ingredient(TechType.Titanium, 2),}};
CraftDataHandler.SetTechData(TechType.FlashlightHelmet, flashlightHelmet);
}


//////// DIVIDER ////////

public static void ApplySolar()
{
var solarPanel = new RecipeData(){
craftAmount = 1, Ingredients = {
new Ingredient(TechType.Quartz, 1),
new Ingredient(TechType.Titanium, 1),
new Ingredient(TechType.Copper, 1),}};
CraftDataHandler.SetTechData(TechType.SolarPanel, solarPanel);
}


//////// DIVIDER ////////

public static void ApplyBattery()
{
var battery = new RecipeData() { craftAmount = 1, Ingredients = {
new Ingredient(TechType.GenericRibbon, 1),
new Ingredient(TechType.Copper, 1),}};
CraftDataHandler.SetTechData(TechType.Battery, battery);
        }
    }
}
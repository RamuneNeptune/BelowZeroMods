using SMLHelper.V2.Options.Attributes;
using QModManager.API.ModLoading;
using SMLHelper.V2.Handlers;
using SMLHelper.V2.Json;
using SMLHelper.V2.Options;
using SMLHelper.V2.Utility;
using QModManager.Utility;


namespace ItemBackgrounds
{
    [Menu("<b>Item Backgrounds</b>")]
    public class MyConfig : ConfigFile
    {
        public static MyConfig Config { get; } = OptionsPanelHandler.RegisterModOptions<MyConfig>();

        // Tools
        [Choice("Tools", new[] { MainClass.Default_, MainClass.Red_, MainClass.Orange_, MainClass.Yellow_, MainClass.Green_, MainClass.Blue_, MainClass.LightBlue_, MainClass.Pink_, MainClass.Purple_, MainClass.White_, MainClass.Black_ }, Tooltip = MainClass.Tooltip), OnChange(nameof(ToolsEvent))]
        public string configTools = MainClass.Default_;

        // Resources
        [Choice("Resources", new[] { MainClass.Default_, MainClass.Red_, MainClass.Orange_, MainClass.Yellow_, MainClass.Green_, MainClass.Blue_, MainClass.LightBlue_, MainClass.Pink_, MainClass.Purple_, MainClass.White_, MainClass.Black_ }, Tooltip = MainClass.Tooltip), OnChange(nameof(ResourcesEvent))]
        public string configResource = MainClass.Default_;

        // Electronics
        [Choice("Electronics", new[] { MainClass.Default_, MainClass.Red_, MainClass.Orange_, MainClass.Yellow_, MainClass.Green_, MainClass.Blue_, MainClass.LightBlue_, MainClass.Pink_, MainClass.Purple_, MainClass.White_, MainClass.Black_ }, Tooltip = MainClass.Tooltip), OnChange(nameof(ElectronicsEvent))]
        public string configElec = MainClass.Default_;

        // Synthetics
        [Choice("Synthetics (crafted materials)", new[] { MainClass.Default_, MainClass.Red_, MainClass.Orange_, MainClass.Yellow_, MainClass.Green_, MainClass.Blue_, MainClass.LightBlue_, MainClass.Pink_, MainClass.Purple_, MainClass.White_, MainClass.Black_ }, Tooltip = MainClass.Tooltip), OnChange(nameof(SyntheticsEvent))]
        public string configSynth = MainClass.Default_;

        // Land Flora
        [Choice("Land Flora (e.g. frost vase)", new[] { MainClass.Default_, MainClass.Red_, MainClass.Orange_, MainClass.Yellow_, MainClass.Green_, MainClass.Blue_, MainClass.LightBlue_, MainClass.Pink_, MainClass.Purple_, MainClass.White_, MainClass.Black_ }, Tooltip = MainClass.Tooltip), OnChange(nameof(LandEvent))]
        public string configLand = MainClass.Default_;

        // Water  Flora
        [Choice("Water Flora (e.g. table coral)", new[] { MainClass.Default_, MainClass.Red_, MainClass.Orange_, MainClass.Yellow_, MainClass.Green_, MainClass.Blue_, MainClass.LightBlue_, MainClass.Pink_, MainClass.Purple_, MainClass.White_, MainClass.Black_ }, Tooltip = MainClass.Tooltip), OnChange(nameof(WaterEvent))]
        public string configWater = MainClass.Default_;

        // Raw Fish
        [Choice("Raw Fish", new[] { MainClass.Default_, MainClass.Red_, MainClass.Orange_, MainClass.Yellow_, MainClass.Green_, MainClass.Blue_, MainClass.LightBlue_, MainClass.Pink_, MainClass.Purple_, MainClass.White_, MainClass.Black_ }, Tooltip = MainClass.Tooltip), OnChange(nameof(RawEvent))]
        public string configRaw = MainClass.Default_;

        // Cooked Fish
        [Choice("Cooked Fish", new[] { MainClass.Default_, MainClass.Red_, MainClass.Orange_, MainClass.Yellow_, MainClass.Green_, MainClass.Blue_, MainClass.LightBlue_, MainClass.Pink_, MainClass.Purple_, MainClass.White_, MainClass.Black_ }, Tooltip = MainClass.Tooltip), OnChange(nameof(CookedEvent))]
        public string configCooked = MainClass.Default_;

        // Equipables
        [Choice("Equipables", new[] { MainClass.Default_, MainClass.Red_, MainClass.Orange_, MainClass.Yellow_, MainClass.Green_, MainClass.Blue_, MainClass.LightBlue_, MainClass.Pink_, MainClass.Purple_, MainClass.White_, MainClass.Black_ }, Tooltip = MainClass.Tooltip), OnChange(nameof(EquipablesEvent))]
        public string configEquip = MainClass.Default_;



        // Tools
        private void ToolsEvent(ChoiceChangedEventArgs e)
        {
            MainClass.PatchTools();
        }


        // Tools
        private void ResourcesEvent(ChoiceChangedEventArgs e)
        {
            MainClass.PatchResources();
        }


        // Tools
        private void ElectronicsEvent(ChoiceChangedEventArgs e)
        {
            MainClass.PatchElectronics();
        }


        // Tools
        private void SyntheticsEvent(ChoiceChangedEventArgs e)
        {
            MainClass.PatchSynthetics();
        }


        // Tools
        private void LandEvent(ChoiceChangedEventArgs e)
        {
            MainClass.PatchLandFlora();
        }


        // Tools
        private void WaterEvent(ChoiceChangedEventArgs e)
        {
            MainClass.PatchWaterFlora();
        }


        // Tools
        private void RawEvent(ChoiceChangedEventArgs e)
        {
            MainClass.PatchRaw();
        }


        // Tools
        private void CookedEvent(ChoiceChangedEventArgs e)
        {
            MainClass.PatchCooked();
        }


        // Tools
        private void EquipablesEvent(ChoiceChangedEventArgs e)
        {
            MainClass.PatchEquipables();
        }
    }
}

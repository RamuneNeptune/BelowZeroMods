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

        public const string Default = "0/0 - None";
        public const string Red = "<color=#F07573>1/10 - Red</color>";
        public const string Orange = "<color=#FFA000>2/10 - Orange</color>";
        public const string Yellow = "<color=#FFD54F>3/10 - Yellow</color>";
        public const string Green = "<color=#81C784>4/10 - Green</color>";
        public const string Blue = "<color=#1E88E5>5/10 - Blue</color>";
        public const string LightBlue = "<color=#26C6DA>6/10 - Light Blue</color>";
        public const string Pink = "<color=#E988A9>7/10 - Pink</color>";
        public const string Purple = "<color=#945DB6>8/10 - Purple</color>";
        public const string White = "<color=#FFFFFF>9/10 - White</color>";
        public const string Black = "<color=#2f2f2e>10/10 - Black</color>";
        public const string Tooltip = "Note: Items in your inventory need to be refreshed by putting them into storage, and pulling them back out.";

        // Tools
        [Choice("Tools", new[] { Default, Red, Orange, Yellow, Green, Blue, LightBlue, Pink, Purple, White, Black }, Tooltip = Tooltip), OnChange(nameof(ToolsEvent))]
        public string configTools = Default;

        // Resources
        [Choice("Resources", new[] { Default, Red, Orange, Yellow, Green, Blue, LightBlue, Pink, Purple, White, Black }, Tooltip = Tooltip), OnChange(nameof(ResourcesEvent))]
        public string configResource = Default;

        // Electronics
        [Choice("Electronics", new[] { Default, Red, Orange, Yellow, Green, Blue, LightBlue, Pink, Purple, White, Black }, Tooltip = Tooltip), OnChange(nameof(ElectronicsEvent))]
        public string configElec = Default;

        // Synthetics
        [Choice("Synthetics (crafted materials)", new[] { Default, Red, Orange, Yellow, Green, Blue, LightBlue, Pink, Purple, White, Black }, Tooltip = Tooltip), OnChange(nameof(SyntheticsEvent))]
        public string configSynth = Default;

        // Land Flora
        [Choice("Land Flora (e.g. frost vase)", new[] { Default, Red, Orange, Yellow, Green, Blue, LightBlue, Pink, Purple, White, Black }, Tooltip = Tooltip), OnChange(nameof(LandEvent))]
        public string configLand = Default;

        // Water  Flora
        [Choice("Water Flora (e.g. table coral)", new[] { Default, Red, Orange, Yellow, Green, Blue, LightBlue, Pink, Purple, White, Black }, Tooltip = Tooltip), OnChange(nameof(WaterEvent))]
        public string configWater = Default;

        // Raw Fish
        [Choice("Raw Fish", new[] { Default, Red, Orange, Yellow, Green, Blue, LightBlue, Pink, Purple, White, Black }, Tooltip = Tooltip), OnChange(nameof(RawEvent))]
        public string configRaw = Default;

        // Cooked Fish
        [Choice("Cooked Fish", new[] { Default, Red, Orange, Yellow, Green, Blue, LightBlue, Pink, Purple, White, Black }, Tooltip = Tooltip), OnChange(nameof(CookedEvent))]
        public string configCooked = Default;

        // Equipables
        [Choice("Equipables", new[] { Default, Red, Orange, Yellow, Green, Blue, LightBlue, Pink, Purple, White, Black }, Tooltip = Tooltip), OnChange(nameof(EquipablesEvent))]
        public string configEquip = Default;



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

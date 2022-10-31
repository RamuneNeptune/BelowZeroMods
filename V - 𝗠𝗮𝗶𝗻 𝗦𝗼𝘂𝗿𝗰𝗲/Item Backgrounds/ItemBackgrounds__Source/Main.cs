
using QModManager.API.ModLoading;

namespace ItemBackgrounds
{
    [QModCore]
    public static class Main
    {
        [QModPatch]
        public static void Load()
        {
            MyConfig.Config.Load();
        }
    }
}
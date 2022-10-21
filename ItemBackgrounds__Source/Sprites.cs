
using Sprite = UnityEngine.Sprite;

using System.Reflection;
using System.IO;

using SMLHelper.V2.Utility;

namespace ItemBackgrounds
{
    public static class Sprites
    {
        // Create sprites for Basic colors
        public static Sprite Black = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "ColorBlack.png"));
        public static Sprite Blue = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "ColorBlue.png"));
        public static Sprite Green = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "ColorGreen.png"));
        public static Sprite LightBlue = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "ColorLightBlue.png"));
        public static Sprite Orange = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "ColorOrange.png"));
        public static Sprite Pink = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "ColorPink.png"));
        public static Sprite Purple = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "ColorPurple.png"));
        public static Sprite Red = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "ColorRed.png"));
        public static Sprite White = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "ColorWhite.png"));
        public static Sprite Yellow = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "ColorYellow.png"));

        // Create sprites for Pure colors
        public static Sprite PureBlack = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "PureBlack.png"));
        public static Sprite PureBlue = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "PureBlue.png"));
        public static Sprite PureGreen = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "PureGreen.png"));
        public static Sprite PureLightBlue = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "PureLightBlue.png"));
        public static Sprite PureOrange = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "PureOrange.png"));
        public static Sprite PurePink = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "PurePink.png"));
        public static Sprite PurePurple = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "PurePurple.png"));
        public static Sprite PureRed = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "PureRed.png"));
        public static Sprite PureWhite = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "PureWhite.png"));
        public static Sprite PureYellow = ImageUtils.LoadSpriteFromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Assets", "PureYellow.png"));
    }
}

using GigaPixelRumble.Game.Screens;
using osu.Framework.Graphics;
using osu.Framework.Screens;
using osu.Framework.Testing;

namespace GigaPixelRumble.Game.Tests.Visual
{
    public class TestSceneSplashScreen : TestScene
    {
        // Add visual tests to ensure correct behaviour of your game: https://github.com/ppy/osu-framework/wiki/Development-and-Testing
        // You can make changes to classes associated with the tests and they will recompile and update immediately.

        public TestSceneSplashScreen()
        {
            Add(new ScreenStack(new SplashScreen()) { RelativeSizeAxes = Axes.Both });
        }
    }
}

using GigaPixelRumble.Game.Screens.Menu;
using osu.Framework.Graphics;
using osu.Framework.Screens;
using osu.Framework.Testing;

namespace GigaPixelRumble.Game.Tests.Visual
{
    public class TestSceneMenuScreen : TestScene
    {
        // Add visual tests to ensure correct behaviour of your game: https://github.com/ppy/osu-framework/wiki/Development-and-Testing
        // You can make changes to classes associated with the tests and they will recompile and update immediately.

        public TestSceneMenuScreen()
        {
            Add(new ScreenStack(new MenuScreen()) { RelativeSizeAxes = Axes.Both });
        }
    }
}

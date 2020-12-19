using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Screens;
using osuTK;

namespace GigaPixelRumble.Game.Screens
{
    public class SplashScreen : Screen
    {

        [BackgroundDependencyLoader]
        private void load()
        {
            InternalChildren = new Drawable[]
            {
                new SpriteText
                {
                    Origin = Anchor.Centre,
                    RelativeAnchorPosition = new Vector2(0.5f, 0.32f),
                    Text = "Giga Pixel Rumble",
                    Font = FontUsage.Default.With(size: 200)
                },
                new SpriteText
                {
                    RelativeAnchorPosition = new Vector2(0.5f, 0.67f),
                    Origin = Anchor.Centre,
                    Text = "Tap to Start",
                    Font = FontUsage.Default.With(size: 120)
                }
            };
        }

        protected override void LoadComplete()
        {
            base.LoadComplete();
        }
    }
}

using GigaPixelRumble.Game.Screens.Common;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Input.Events;
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
                new GigaPixelLogo
                {
                    Origin = Anchor.Centre,
                    RelativeAnchorPosition = new Vector2(0.5f, 0.32f),
                    Scale = new Vector2(2)
                },
                new SpriteText
                {
                    RelativeAnchorPosition = new Vector2(0.5f, 0.75f),
                    Origin = Anchor.Centre,
                    Text = "Tap to Start",
                    Font = FontUsage.Default.With(size: 100)
                }
            };
        }

        protected override void LoadComplete()
        {
            base.LoadComplete();
        }

        protected override bool OnClick(ClickEvent e)
        {
            StartGame();
            return true;
        }

        protected override bool OnTouchDown(TouchDownEvent e)
        {
            StartGame();
            return true;
        }

        private void StartGame()
        {

        }
    }
}

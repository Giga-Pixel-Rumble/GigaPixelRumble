using System;
using System.Collections.Generic;
using System.Text;
using GigaPixelRumble.Game.Screens.Common;
using osu.Framework;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Input;
using osu.Framework.Screens;
using osuTK;

namespace GigaPixelRumble.Game.Screens.Menu
{
    public class MenuScreen : Screen
    {

        private Container menuButtons;

        [BackgroundDependencyLoader]
        private void load()
        {
            InternalChildren = new Drawable[]
            {
                new GigaPixelLogo
                {
                    Origin = Anchor.TopLeft,
                    Anchor = Anchor.TopLeft,
                    Scale = new Vector2(0.5f)
                },
                menuButtons = new Container
                {
                    AutoSizeAxes = Axes.Both,
                    Origin = Anchor.CentreLeft,
                    Anchor = Anchor.CentreLeft,
                    Children = new []
                    {
                        new MenuButton("Play")
                        {
                            Origin = Anchor.TopLeft,
                            RelativeAnchorPosition = new Vector2(0)
                        },
                        new MenuButton("Create")
                        {
                            Origin = Anchor.TopLeft,
                            RelativeAnchorPosition = new Vector2(0, 0.25f)
                        },
                        new MenuButton("Shop")
                        {
                            Origin = Anchor.TopLeft,
                            RelativeAnchorPosition = new Vector2(0, 0.5f)
                        },
                        new MenuButton("Settings")
                        {
                            Origin = Anchor.TopLeft,
                            RelativeAnchorPosition = new Vector2(0, 0.75f)
                        }
                    }
                },
                new QuitButton
                {
                    Origin = Anchor.BottomLeft,
                    Anchor = Anchor.BottomLeft,
                    Action = () => {
                        Game.Exit();
                    }
                }
            };
        }
    }
}

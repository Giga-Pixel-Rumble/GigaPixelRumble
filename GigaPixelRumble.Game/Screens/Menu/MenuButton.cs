using System;
using System.Collections.Generic;
using System.Text;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.UserInterface;

namespace GigaPixelRumble.Game.Screens.Menu
{
    public class MenuButton : Button
    {
        public readonly float HORIZONTAL_PADDING = 16f;
        public readonly float VERTICAL_PADDING = 8f;

        public readonly float WIDTH = 250f;
        public readonly float HEIGHT = 75f;

        public MenuButton(string text)
        {
            Padding = new MarginPadding
            {
                Horizontal = HORIZONTAL_PADDING,
                Vertical = VERTICAL_PADDING
            };
            AutoSizeAxes = Axes.Both;
            Child = new Container()
            {
                Size = new osuTK.Vector2(WIDTH, HEIGHT),
                AlwaysPresent = true,
                Children = new Drawable[]
                {
                    new Box
                    {
                        Colour = Colour4.HotPink,
                        RelativeSizeAxes = Axes.Both,
                        Size = new osuTK.Vector2(1)
                    },
                    new SpriteText()
                    {
                        Origin = Anchor.Centre,
                        Anchor = Anchor.Centre,
                        Text = text
                    }
                }
            };
        }
    }
}

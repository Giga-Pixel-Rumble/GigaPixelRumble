using System;
using System.Collections.Generic;
using System.Text;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.UserInterface;
using osuTK;

namespace GigaPixelRumble.Game.Screens.Common
{
    public class QuitButton : Button
    {

        public readonly float PADDING = 16f;

        public readonly float SIZE = 50f;

        public QuitButton(osu.Framework.Game game)
        {
            Action = () =>
            {
                game.Exit();
            };
            Padding = new MarginPadding(PADDING);
            AutoSizeAxes = Axes.Both;
            Child = new Container
            {
                Size = new Vector2(SIZE),
                AlwaysPresent = true,
                Children = new []
                {
                    new Circle
                    {
                        Colour = Colour4.White,
                        RelativeSizeAxes = Axes.Both,
                        Size = new Vector2(1)
                    }
                }
            };
        }
    }
}

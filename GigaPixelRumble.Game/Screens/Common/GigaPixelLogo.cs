using System;
using System.Collections.Generic;
using System.Text;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Sprites;

namespace GigaPixelRumble.Game.Screens.Common
{
    public class GigaPixelLogo : CompositeDrawable
    {
        [BackgroundDependencyLoader]
        private void load()
        {
            // This is just a placeholder until we get a proper logo to use
            AutoSizeAxes = Axes.Both;
            InternalChildren = new Drawable[]
            {
                new SpriteText
                {
                    Origin = Anchor.BottomCentre,
                    Anchor = Anchor.Centre,
                    Text = "Giga Pixel",
                    Font = new FontUsage(family: "PressStartP2", size: 60)
                },
                new SpriteText
                {
                    Origin = Anchor.TopCentre,
                    Anchor = Anchor.Centre,
                    Text = "Rumble",
                    Font = new FontUsage(family: "PressStartP2", size: 90)
                }
            };
        }
    }
}

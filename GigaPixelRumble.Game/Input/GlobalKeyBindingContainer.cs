using System;
using System.Collections.Generic;
using System.Text;
using osu.Framework.Input.Bindings;

namespace GigaPixelRumble.Game.Input
{
    public enum GlobalAction
    {
        Back,
        Click
    }

    public class GlobalKeyBindingContainer : KeyBindingContainer<GlobalAction>
    {
        public override IEnumerable<KeyBinding> DefaultKeyBindings => new[]
        {
            new KeyBinding(new[] { InputKey.Escape }, GlobalAction.Back),
            new KeyBinding(new[] { InputKey.MouseLeft }, GlobalAction.Click)
        };
    }
}

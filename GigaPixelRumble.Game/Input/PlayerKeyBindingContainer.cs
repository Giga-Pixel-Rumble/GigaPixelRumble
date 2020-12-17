using System;
using System.Collections.Generic;
using osu.Framework.Input.Bindings;

namespace GigaPixelRumble.Game.Input
{
    public enum PlayerAction
    {
        MoveLeft,
        MoveRight,
        Jump,
        Attack
    }

    public class PlayerKeyBindingContainer : KeyBindingContainer<PlayerAction>
    {
        public PlayerKeyBindingContainer(
            KeyCombinationMatchingMode keyCombinationMatchingMode = KeyCombinationMatchingMode.Any,
            SimultaneousBindingMode simultaneousBindingMode = SimultaneousBindingMode.All
        ) : base(simultaneousBindingMode, keyCombinationMatchingMode)
        {
        }

        public override IEnumerable<KeyBinding> DefaultKeyBindings => new[]
        {
            new KeyBinding(new[] { InputKey.A }, PlayerAction.MoveLeft),
            new KeyBinding(new[] { InputKey.D }, PlayerAction.MoveRight),
            new KeyBinding(new[] { InputKey.W }, PlayerAction.Jump),
            new KeyBinding(new[] { InputKey.Space }, PlayerAction.Attack)
        };
    }
}

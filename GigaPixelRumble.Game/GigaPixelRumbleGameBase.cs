using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.IO.Stores;
using osuTK;
using GigaPixelRumble.Resources;
using osu.Framework.Graphics.Textures;
using osuTK.Graphics.ES30;

namespace GigaPixelRumble.Game
{
    public class GigaPixelRumbleGameBase : osu.Framework.Game
    {
        // Anything in this class is shared between the test browser and the game implementation.
        // It allows for caching global dependencies that should be accessible to tests, or changing
        // the screen scaling for all components including the test browser and framework overlays.

        protected override Container<Drawable> Content { get; }

        private TextureStore textures;

        private DependencyContainer dependencies;

        protected GigaPixelRumbleGameBase()
        {
            // Ensure game and tests scale with window size and screen DPI.
            base.Content.Add(Content = new DrawSizePreservingFillContainer
            {
                // You may want to change TargetDrawSize to your "default" resolution, which will decide how things scale and position when using absolute coordinates.
                TargetDrawSize = new Vector2(1366, 768)
            });
        }

        [BackgroundDependencyLoader]
        private void load()
        {
            Resources.AddStore(new DllResourceStore(typeof(GigaPixelRumbleResources).Assembly));

            var fontStore = new FontStore(minFilterMode: All.Nearest);
            Fonts.AddStore(fontStore);
            AddFont(Resources, @"Fonts/PressStartP2", fontStore);

            textures = new TextureStore(Textures, filteringMode: All.Nearest);
            dependencies.Cache(textures);
        }

        protected override IReadOnlyDependencyContainer CreateChildDependencies(IReadOnlyDependencyContainer parent)
            => dependencies = new DependencyContainer(base.CreateChildDependencies(parent));
    }
}

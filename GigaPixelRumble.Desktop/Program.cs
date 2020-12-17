using osu.Framework.Platform;
using osu.Framework;
using GigaPixelRumble.Game;

namespace GigaPixelRumble.Desktop
{
    public static class Program
    {
        public static void Main()
        {
            using (GameHost host = Host.GetSuitableHost(@"GigaPixelRumble"))
            using (osu.Framework.Game game = new GigaPixelRumbleGame())
                host.Run(game);
        }
    }
}

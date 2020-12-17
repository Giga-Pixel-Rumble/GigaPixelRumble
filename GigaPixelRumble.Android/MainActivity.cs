using Android.App;
using GigaPixelRumble.Game;
using osu.Framework.Android;

namespace GigaPixelRumble.Android
{
    [Activity(Label = "@string/app_name", Theme = "@android:style/Theme.NoTitleBar", MainLauncher = true)]
    public class MainActivity : AndroidGameActivity
    {
        protected override osu.Framework.Game CreateGame() => new GigaPixelRumbleGame();
    }
}

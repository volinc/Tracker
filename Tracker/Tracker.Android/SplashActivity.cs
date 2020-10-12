namespace Tracker.Droid
{
    using Android.App;
    using Android.Content;

    [Activity(Theme = "@style/MainTheme.Splash",
        MainLauncher = true,
        NoHistory = true)]
    public class SplashActivity : Activity
    {
        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}
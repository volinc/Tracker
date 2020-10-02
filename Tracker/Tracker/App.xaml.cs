namespace Tracker
{
    using Xamarin.Forms;
    using Tracker.Views;
    using Shiny.Locations;
    using System;

    public partial class App : Application
    {
        private readonly IGpsManager gpsManager;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            gpsManager = Shiny.ShinyHost.Resolve<IGpsManager>();
        }

        protected override void OnStart()
        {
            gpsManager.StartListener(new GpsRequest
            {
                ThrottledInterval = TimeSpan.FromSeconds(2),
                Interval = TimeSpan.FromSeconds(4),
                Priority = GpsPriority.Highest,
                UseBackground = true
            });
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

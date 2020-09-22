namespace Tracker
{
    using Xamarin.Forms;
    using Tracker.Views;
    using Shiny.Locations;

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
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

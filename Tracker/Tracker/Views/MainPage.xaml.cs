using System;
using System.ComponentModel;
using Shiny;
using Shiny.Locations;
using Xamarin.Forms;

namespace Tracker.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly IGpsManager gpsManager;

        public MainPage()
        {
            InitializeComponent();

            gpsManager = Shiny.ShinyHost.Resolve<IGpsManager>();

            gpsManager.WhenReading().Subscribe(r =>
            {
                var position = r.Position;
                Lat.Text = position?.Latitude.ToString();
                Lon.Text = position?.Longitude.ToString();
            });
        }
    }
}
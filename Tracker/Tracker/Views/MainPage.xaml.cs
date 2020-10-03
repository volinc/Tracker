using System;
using System.ComponentModel;
using Shiny.Locations;
using Xamarin.Forms;

namespace Tracker.Views
{
    using System.Globalization;

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var gpsManager = Shiny.ShinyHost.Resolve<IGpsManager>();

            gpsManager.WhenReading().Subscribe(r =>
            {
                var position = r.Position;
                Lat.Text = position.Latitude.ToString(CultureInfo.InvariantCulture);
                Lon.Text = position.Longitude.ToString(CultureInfo.InvariantCulture);
            });
        }
    }
}
namespace Tracker.Droid
{
    using System;
    using Android.App;
    using Android.Runtime;

    [Application]
    public class MainApplication : Shiny.ShinyAndroidApplication<YourStartup>
    {
        public MainApplication(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            Xamarin.Essentials.Platform.Init(this);
        }
    }
}

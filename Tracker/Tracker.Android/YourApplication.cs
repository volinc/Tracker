namespace Tracker.Droid
{
    using System;
    using Shiny;
    using Android.App;
    using Android.Runtime;

    [Application]
    public class YourApplication : Shiny.ShinyAndroidApplication<YourStartup>
    {
        public YourApplication(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

            Shiny.AndroidShinyHost.Init(this, new YourStartup());
        }
    }
}

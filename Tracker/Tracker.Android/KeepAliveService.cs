namespace Tracker.Droid
{
    using Android.App;
    using Android.Content;
    using Android.OS;

    [Service]
    public class KeepAliveService : Service
    {
        public override IBinder OnBind(Intent intent) => null;

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            var notification = this.CreateNotification(Constants.KeepAliveNotificationChannelId);
            StartForeground(Constants.KeepAliveNotificationId, notification);

            return intent == null
                ? StartCommandResult.StickyCompatibility
                : StartCommandResult.Sticky;
        }
    }
}
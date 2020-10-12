namespace Tracker.Droid
{
    using Android.App;
    using Android.Content;
    using Android.OS;
    using AndroidX.Core.App;

    public static class ContextExtensions
    {
        public static void StartForegroundServiceCompat<T>(this Context context, Bundle args = null) where T : Service
        {
            var intent = new Intent(context, typeof(T));
            if (args != null)
            {
                intent.PutExtras(args);
            }

            if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
            {
                context.StartForegroundService(intent);
            }
            else
            {
                context.StartService(intent);
            }
        }

        public static Notification CreateNotification(this Context context, string channelId)
        {
            var intent = new Intent(context, typeof(MainActivity));
            var pendingIntent = PendingIntent.GetActivity(context, 0, intent, PendingIntentFlags.OneShot);

            const string title = "Tracker";
            const string text = "keepAlive...";

            return new NotificationCompat.Builder(context, channelId)
                .SetContentTitle(title)
                .SetContentText(text)
                .SetSmallIcon(Android.Resource.Drawable.ArrowUpFloat)
                .SetContentIntent(pendingIntent)
                .SetOngoing(true)
                .Build();
        }

        public static void CreateNotificationChannel(this Context context, string channelId, string name)
        {
            if (Build.VERSION.SdkInt < BuildVersionCodes.O)
                return;

            var channel = new NotificationChannel(channelId, name, NotificationImportance.High);
            channel.SetSound(null, null);
            channel.EnableVibration(true);
            channel.EnableLights(false);
            channel.LockscreenVisibility = NotificationVisibility.Public;

            var notificationManager = NotificationManager.FromContext(context);
            notificationManager?.CreateNotificationChannel(channel);
        }
    }
}
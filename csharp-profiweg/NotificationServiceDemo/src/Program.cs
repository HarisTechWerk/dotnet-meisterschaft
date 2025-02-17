using System;

namespace NotificationServiceDemo.src
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inject different notification services dynamically

            // Email Notification
            var emailManager = new NotificationManager(new EmailNotificationService());
            emailManager.NotifyUser("Welcome to our Service!", "user@email.de");

            // SMS Notification
            var smsManager = new NotificationManager(new SMSNotificationService());
            smsManager.NotifyUser("Welcome to our Service!", "+49123456789");

            // Push Notification
            var pushManager = new NotificationManager(new PushNotificationService());
            pushManager.NotifyUser("Welcome to our Service!", "user_device_token");

        }
    }
}
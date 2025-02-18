using NotificationServiceDemo.src;
using System;

namespace NotificationServiceDemo
{
    class Program
    {
        static void Main()
        {
            // Inject different notification services dynamically

            // Email Notification
            var emailManager = new NotificationManager(new EmailNotificationService());
            emailManager.NotifyUser("Welcome to our service!", "user@example.com");

            // SMS Notification
            var smsManager = new NotificationManager(new SMSNotificationService());
            smsManager.NotifyUser("Your OTP is 1234", "+123456789");

            // Push Notification
            var pushManager = new NotificationManager(new PushNotificationService());
            pushManager.NotifyUser("New update available!", "user_device_token");
        }
    }
}

using System;

namespace NotificationServiceDemo.src
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificationService emailService = new EmailNotificationService();


            emailService.SendNotification("Welcome to our Service!", "user@email.com");

            INotificationService smsService = new SMSNotificationService();
            smsService.SendNotification("Welcome to our Service!", "+49123456789");

            INotificationService pushService = new PushNotificationService();
            pushService.SendNotification("Welcome to our Service", "user_device_token");
        }
    }
}
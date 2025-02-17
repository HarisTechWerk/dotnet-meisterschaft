using System;

namespace NotificationServiceDemo.src
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificationService emailService = new EmailNotificationService();

            emailService.SendNotification("Welcome to our Service!", "user@email.com");
        }
    }
}
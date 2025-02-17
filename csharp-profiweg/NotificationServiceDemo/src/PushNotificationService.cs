using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationServiceDemo.src
{
    public class PushNotificationService : INotificationService

    {
        public void SendNotification(string message, string recipient)
        {
            Console.WriteLine($"🔔 Push notification sent to {recipient} with message: {message}");
        }

    }
}

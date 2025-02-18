using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationServiceDemo.src
{
    public abstract class BaseNotificationService : INotificationService
    {
        public void SendNotification(string message, string recipient)
        {
            string notificationType = GetNotificationType();
            Console.WriteLine($"📢 Sending {notificationType} to {recipient} with message: {message}");
        }

        protected abstract string GetNotificationType();

    }
    
}

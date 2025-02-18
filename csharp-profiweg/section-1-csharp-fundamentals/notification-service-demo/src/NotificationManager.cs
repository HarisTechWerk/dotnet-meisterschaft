using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationServiceDemo.src
{
    public class NotificationManager
    {
        private readonly INotificationService _notificationService;

        public NotificationManager(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void NotifyUser(string message, string recipient)
        {
            _notificationService.SendNotification(message, recipient);
        }
    }
}

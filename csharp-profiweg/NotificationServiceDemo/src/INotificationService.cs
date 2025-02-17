using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationServiceDemo.src
{
    public interface INotificationService
    {
        void SendNotification(string message, string recipient);
    }
}

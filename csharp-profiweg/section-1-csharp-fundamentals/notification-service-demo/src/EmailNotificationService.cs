using NotificationServiceDemo.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationServiceDemo
{
    public class EmailNotificationService : BaseNotificationService
    {
        protected override string GetNotificationType()
        {
            return "Email";
        }
    }
}

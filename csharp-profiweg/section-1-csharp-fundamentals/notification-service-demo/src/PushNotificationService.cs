﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationServiceDemo.src
{
    public class PushNotificationService : BaseNotificationService

    {
        protected override string GetNotificationType()
        {
            return "Push Notification";
        }

    }
}

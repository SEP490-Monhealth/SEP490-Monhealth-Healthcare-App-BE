﻿using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.UserNotification.Queries.GetAllUserNotifications
{
    public class GetAllUserNotificationsDTO : TimeEntity
    {
        public Guid UserNotificationId { get; set; }
        public Guid UserId { get; set; }
        public Guid NotificationId { get; set; }
        public bool isRead { get; set; }
    }
}

﻿using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Notification.Queries.GetNotificationByUserId
{
    public class GetNotificationByUserIdDTO : BaseEntity
    {
        public Guid NotificationId { get; set; }
        public Guid ReferenceId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string? ActionUrl { get; set; }
    }
}

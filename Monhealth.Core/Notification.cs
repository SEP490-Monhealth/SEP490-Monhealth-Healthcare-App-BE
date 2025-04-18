﻿using Monhealth.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Monhealth.Domain
{
    public class Notification : TimeEntity
    {
        [Key]
        public Guid NotificationId { get; set; }
        public Guid? ReferenceId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string? ActionUrl { get; set; }

        public ICollection<UserNotification> UserNotifications { get; set; }
    }
}

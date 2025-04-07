using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Monhealth.Domain.Common;
using Monhealth.Identity.Models;

namespace Monhealth.Domain
{
    public class UserNotification : TimeEntity
    {
        [Key]
        public Guid UserNotificationId { get; set; }
        public Guid UserId { get; set; }
        public Guid NotificationId { get; set; }
        public bool IsRead { get; set; } = false;

        [ForeignKey(nameof(UserId))]
        public AppUser AppUser { get; set; }
        [ForeignKey(nameof(NotificationId))]
        public Notification Notification { get; set; }
    }
}

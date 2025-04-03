using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationByNotificationId
{
    public class GetUserNotificationByNotificationIdDTO : TimeEntity
    {
        public Guid UserNotificationId { get; set; }
        public Guid UserId { get; set; }
        public Guid NotificationId { get; set; }
        public bool isRead { get; set; } = false;
    }
}

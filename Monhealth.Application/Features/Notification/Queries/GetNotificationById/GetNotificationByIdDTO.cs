using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Notification.Queries.GetNotificationById
{
    public class GetNotificationByIdDTO : TimeEntity
    {
        public Guid NotificationId { get; set; }
        public Guid ReferenceId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string? ActionUrl { get; set; }
        public bool IsRead { get; set; }
    }
}

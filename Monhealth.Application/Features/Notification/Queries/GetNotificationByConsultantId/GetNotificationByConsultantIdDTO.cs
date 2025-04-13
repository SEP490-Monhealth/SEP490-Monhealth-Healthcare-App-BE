using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Notification.Queries.GetNotificationByConsultantId
{
    public class GetNotificationByConsultantIdDTO : BaseEntity
    {
        public Guid NotificationId { get; set; }
        public Guid ReferenceId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string? ActionUrl { get; set; }
    }
}

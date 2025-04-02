using MediatR;

namespace Monhealth.Application.Features.Notification.Queries.GetNotificationById
{
    public class GetNotificationByIdQuery : IRequest<GetNotificationByIdDTO>
    {
        public Guid NotificationId { get; set; }
    }
}

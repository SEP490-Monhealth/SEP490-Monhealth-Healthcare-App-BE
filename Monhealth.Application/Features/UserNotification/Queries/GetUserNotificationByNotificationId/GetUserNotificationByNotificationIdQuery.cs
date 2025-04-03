using MediatR;

namespace Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationByNotificationId
{
    public class GetUserNotificationByNotificationIdQuery : IRequest<List<GetUserNotificationByNotificationIdDTO>>
    {
        public Guid NotificationId { get; set; }
    }
}

using MediatR;

namespace Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationById
{
    public class GetUserNotificationByIdQuery : IRequest<GetUserNotificationByIdDTO>
    {
        public Guid UserNotificationId { get; set; }
    }
}

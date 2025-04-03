using MediatR;

namespace Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationByUserId
{
    public class GetUserNotificationByUserIdQuery : IRequest<List<GetUserNotificationByUserIdDTO>>
    {
        public Guid UserId { get; set; }
    }
}

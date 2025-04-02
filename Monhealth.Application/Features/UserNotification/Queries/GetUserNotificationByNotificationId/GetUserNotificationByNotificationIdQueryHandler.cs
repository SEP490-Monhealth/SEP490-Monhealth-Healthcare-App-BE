using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationByNotificationId
{
    public class GetUserNotificationByNotificationIdQueryHandler(IUserNotificationRepository userNotificationRepository, IMapper mapper) : IRequestHandler<GetUserNotificationByNotificationIdQuery, List<GetUserNotificationByNotificationIdDTO>>
    {
        public async Task<List<GetUserNotificationByNotificationIdDTO>> Handle(GetUserNotificationByNotificationIdQuery request, CancellationToken cancellationToken)
        {
            var userNotification = await userNotificationRepository.GetUserNotificationByNotificationId(request.NotificationId);
            return mapper.Map<List<GetUserNotificationByNotificationIdDTO>>(userNotification);
        }
    }
}

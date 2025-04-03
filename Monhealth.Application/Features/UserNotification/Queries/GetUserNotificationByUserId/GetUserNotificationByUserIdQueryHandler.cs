using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationByNotificationId;

namespace Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationByUserId
{
    public class GetUserNotificationByUserIdQueryHandler(IUserNotificationRepository userNotificationRepository, IMapper mapper) : IRequestHandler<GetUserNotificationByUserIdQuery, List<GetUserNotificationByUserIdDTO>>
    {
        public async Task<List<GetUserNotificationByUserIdDTO>> Handle(GetUserNotificationByUserIdQuery request, CancellationToken cancellationToken)
        {
            var userNotification = await userNotificationRepository.GetUserNotificationByUserId(request.UserId);
            return mapper.Map<List<GetUserNotificationByUserIdDTO>>(userNotification);
        }
    }
}

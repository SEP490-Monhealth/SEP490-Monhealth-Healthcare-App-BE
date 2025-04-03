using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationById
{
    public class GetUserNotificationByIdQueryHandler(IUserNotificationRepository userNotificationRepository, IMapper mapper) : IRequestHandler<GetUserNotificationByIdQuery, GetUserNotificationByIdDTO>
    {
        public async Task<GetUserNotificationByIdDTO> Handle(GetUserNotificationByIdQuery request, CancellationToken cancellationToken)
        {
            var userNotification = await userNotificationRepository.GetByIdAsync(request.UserNotificationId);
            return mapper.Map<GetUserNotificationByIdDTO>(userNotification);
        }
    }
}

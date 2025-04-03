using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Notification.Queries.GetNotificationById
{
    public class GetNotificationByIdQueryHandler(INotificationRepository notificationRepository, IMapper mapper) : IRequestHandler<GetNotificationByIdQuery, GetNotificationByIdDTO>
    {
        public async Task<GetNotificationByIdDTO> Handle(GetNotificationByIdQuery request, CancellationToken cancellationToken)
        {
            var notification = await notificationRepository.GetByIdAsync(request.NotificationId);
            return mapper.Map<GetNotificationByIdDTO>(notification);
        }
    }
}

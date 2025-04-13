using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Notification.Queries.GetAllNotifications;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Notification.Queries.GetNotificationByUserId
{
    public class GetNotificationByUserIdQueryHandler(INotificationRepository notificationRepository, IMapper mapper) : IRequestHandler<GetNotificationByUserIdQuery, PageResult<GetNotificationByUserIdDTO>>
    {
        public async Task<PageResult<GetNotificationByUserIdDTO>> Handle(GetNotificationByUserIdQuery request, CancellationToken cancellationToken)
        {
            var listNotifications = await notificationRepository.GetNotificationByUserId(request.Page, request.Limit, request.UserId);
            var listNotificationsDTO = mapper.Map<List<GetNotificationByUserIdDTO>>(listNotifications.Items);
            return new PageResult<GetNotificationByUserIdDTO>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(listNotifications.TotalCount / (double)request.Limit),
                TotalItems = listNotifications.TotalCount,
                Items = listNotificationsDTO
            };
        }
    }
}

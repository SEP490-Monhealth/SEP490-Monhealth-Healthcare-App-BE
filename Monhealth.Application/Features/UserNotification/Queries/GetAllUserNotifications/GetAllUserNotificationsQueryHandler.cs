using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Notification.Queries.GetAllNotifications;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.UserNotification.Queries.GetAllUserNotifications
{
    public class GetAllUserNotificationsQueryHandler(IUserNotificationRepository userNotificationRepository, IMapper mapper) : IRequestHandler<GetAllUserNotificationsQuery, PageResult<GetAllUserNotificationsDTO>>
    {
        public async Task<PageResult<GetAllUserNotificationsDTO>> Handle(GetAllUserNotificationsQuery request, CancellationToken cancellationToken)
        {
            var listUserNotifications = await userNotificationRepository.GetAllUserNotifications(request.Page, request.Limit, request.Search);
            var listUserNotificationsDTO = mapper.Map<List<GetAllUserNotificationsDTO>>(listUserNotifications.Items);
            return new PageResult<GetAllUserNotificationsDTO>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(listUserNotifications.TotalCount / (double)request.Limit),
                TotalItems = listUserNotifications.TotalCount,
                Items = listUserNotificationsDTO
            };
        }
    }
}

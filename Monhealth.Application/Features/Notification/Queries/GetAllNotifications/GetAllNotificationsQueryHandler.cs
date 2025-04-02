using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Exercise.Queries.GetAllExercises;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Notification.Queries.GetAllNotifications
{
    public class GetAllNotificationsQueryHandler(INotificationRepository notificationRepository, IMapper mapper) : IRequestHandler<GetAllNotificationsQuery, PageResult<GetAllNotificationsDTO>>
    {
        public async Task<PageResult<GetAllNotificationsDTO>> Handle(GetAllNotificationsQuery request, CancellationToken cancellationToken)
        {
            var listNotification = await notificationRepository.GetAllNotificationsAsync(request.Page, request.Limit, request.Search);
            var listNotificationDTO = mapper.Map<List<GetAllNotificationsDTO>>(listNotification.Items);
            return new PageResult<GetAllNotificationsDTO>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(listNotification.TotalCount / (double)request.Limit),
                TotalItems = listNotification.TotalCount,
                Items = listNotificationDTO
            };
        }
    }
}

using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Notification.Queries.GetNotificationByConsultantId
{
    public class GetNotificationByConsultantIdQueryHandler
        (INotificationRepository notificationRepository, IConsultantRepository consultantRepository) :
        IRequestHandler<GetNotificationByConsultantIdQuery, PageResult<GetNotificationByConsultantIdDTO>>
    {
        public async Task<PageResult<GetNotificationByConsultantIdDTO>> Handle(GetNotificationByConsultantIdQuery request, CancellationToken cancellationToken)
        {
            var consultant = await consultantRepository.GetConsultantById(request.ConsultantId);
            if (consultant == null) throw new BadRequestException($"{request.ConsultantId} Không phải là ID của tư vấn viên");
            var listNotification = await notificationRepository.GetNotificationByConsultantId(request.Page, request.Limit, consultant.UserId);

            var notificationsDto = listNotification.Items.Select(n => new GetNotificationByConsultantIdDTO
            {
                NotificationId = n.NotificationId,
                ReferenceId = (Guid)n.ReferenceId,
                Title = n.Title,
                Content = n.Content,
                ActionUrl = n.ActionUrl,
                CreatedAt = n.CreatedAt,
                UpdatedAt = n.UpdatedAt
            }).ToList();

            return new PageResult<GetNotificationByConsultantIdDTO>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(listNotification.TotalCount / (double)request.Limit),
                TotalItems = listNotification.TotalCount,
                Items = notificationsDto
            };
        }
    }
}

﻿using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Notification.Queries.GetNotificationByConsultantId
{
    public class GetNotificationByConsultantIdQueryHandler
        (INotificationRepository notificationRepository, IConsultantRepository consultantRepository) : 
        IRequestHandler<GetNotificationByConsultantIdQuery, PageResult<GetNotificationByConsultantIdDTO>>
    {
        public async Task<PageResult<GetNotificationByConsultantIdDTO>> Handle(GetNotificationByConsultantIdQuery request, CancellationToken cancellationToken)
        {
            var listNotification = await notificationRepository.GetNotificationByConsultantId(request.Page, request.Limit, request.ConsultantId);

            var notificationsDto = listNotification.Items.Select(n => new GetNotificationByConsultantIdDTO
            {
                NotificationId = n.NotificationId,
                ReferenceId = n.ReferenceId,
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

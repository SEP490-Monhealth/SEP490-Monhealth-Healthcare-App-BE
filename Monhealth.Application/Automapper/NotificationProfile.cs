using AutoMapper;
using Monhealth.Application.Features.Notification.Commands.CreateNotification;
using Monhealth.Application.Features.Notification.Commands.UpdateNotification;
using Monhealth.Application.Features.Notification.Queries.GetAllNotifications;
using Monhealth.Application.Features.Notification.Queries.GetNotificationById;
using Monhealth.Application.Features.Notification.Queries.GetNotificationByUserId;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class NotificationProfile : Profile
    {
        public NotificationProfile()
        {
            CreateMap<Notification, GetAllNotificationsDTO>().ReverseMap();
            CreateMap<Notification, GetNotificationByIdDTO>().ReverseMap();
            CreateMap<Notification, GetNotificationByUserIdDTO>().ReverseMap();

            CreateMap<Notification, CreateNotificationDTO>().ReverseMap();
            CreateMap<Notification, UpdateNotificationDTO>().ReverseMap();
        }
    }
}

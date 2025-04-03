using AutoMapper;
using Monhealth.Application.Features.UserNotification.Queries.GetAllUserNotifications;
using Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationById;
using Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationByNotificationId;
using Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationByUserId;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class UserNotificationProfile : Profile
    {
        public UserNotificationProfile()
        {
            CreateMap<UserNotification, GetAllUserNotificationsDTO>().ReverseMap();
            CreateMap<UserNotification, GetUserNotificationByIdDTO>().ReverseMap();
            CreateMap<UserNotification, GetUserNotificationByNotificationIdDTO>().ReverseMap();
            CreateMap<UserNotification, GetUserNotificationByUserIdDTO>().ReverseMap();
        }
    }
}

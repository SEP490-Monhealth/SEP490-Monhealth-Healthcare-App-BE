using AutoMapper;
using Monhealth.Application.Features.UserNotification.Queries.GetAllUserNotifications;
using Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationById;
using Monhealth.Application.Features.UserNotification.Queries.GetUserNotificationByNotificationId;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper.CustomFoodMapper
{
    public class UserNotificationProfile : Profile
    {
        public UserNotificationProfile()
        {
            CreateMap<UserNotification, GetAllUserNotificationsDTO>().ReverseMap();
            CreateMap<UserNotification, GetUserNotificationByIdDTO>().ReverseMap();
            CreateMap<UserNotification, GetUserNotificationByNotificationIdDTO>().ReverseMap();
        }
    }
}

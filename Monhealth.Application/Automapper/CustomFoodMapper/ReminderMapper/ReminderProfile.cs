using AutoMapper;
using Monhealth.Application.Features.Reminders.Queries.GetAllReminder;
using Monhealth.Application.Features.Reminders.Queries.GetReminderByUser;
using Monhealth.Application.Features.Reminders.Queries.GetReminderDetail;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper.CustomFoodMapper.ReminderMapper
{
    public class ReminderProfile : Profile
    {
        public ReminderProfile()
        {
            CreateMap<WaterReminder , ReminderDTO>();
            CreateMap<WaterReminder , GetAllReminderByUserDTO>();            
            CreateMap<WaterReminder, ReminderDetailDTO>();
        }


    }
}
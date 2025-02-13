using AutoMapper;
using Monhealth.Application.Features.Schedule.Queries.GetAll;
using Monhealth.Application.Features.Schedule.Queries.GetByUser;
using Monhealth.Application.Features.Subscription.Queries.GetById;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class ScheduleProfile : Profile
    {
        public ScheduleProfile()
        {
            CreateMap<ScheduleDTO, Schedule>().ReverseMap();
            CreateMap<ScheduleDetailDTO, Schedule>()
     // Map ConsultantId from ScheduleDetailDTO to Schedule
     .ForMember(dest => dest.ConsultantId,
         opt => opt.MapFrom(src => src.ConsultantId))

     // Map Date from ScheduleDetailDTO to Schedule
     .ForMember(dest => dest.Date,
         opt => opt.MapFrom(src => src.Date))

     // Map BookedSlots from ScheduleDetailDTO to Schedule
     .ForMember(dest => dest.BookedSlots,
         opt => opt.MapFrom(src => src.BookedSlots))

     // Map StartTime from ScheduleDetailDTO to Schedule
     .ForMember(dest => dest.StartTime,
         opt => opt.MapFrom(src => src.StartTime))

     // Map EndTime from ScheduleDetailDTO to Schedule
     .ForMember(dest => dest.EndTime,
         opt => opt.MapFrom(src => src.EndTime))

     // Map MaxBookings from ScheduleDetailDTO to Schedule
     .ForMember(dest => dest.MaxBookings,
         opt => opt.MapFrom(src => src.MaxBookings))

     // Reverse map: Automatically map from Schedule to ScheduleDetailDTO in reverse
     .ReverseMap();

            CreateMap<GetScheduleByUserDTO, Schedule>().ReverseMap();
        }


    }
}
using AutoMapper;
using Monhealth.Application.Features.TimeSlots.Queries.GetAllTimSlots;
using Monhealth.Domain;

namespace Monhealth.Application.Automapper
{
    public class TimeSlotProfile : Profile
    {
        public TimeSlotProfile()
        {
            CreateMap<TimeSlot, TimeSlotDto>();
        }
    }
}

using MediatR;
using Monhealth.Application.Features.TimeSlots.Queries.GetAllTimSlots;

namespace Monhealth.Application.Features.TimeSlots.Queries.GetTimeSlotById
{
    public class GetTimeSlotByIdQueries : IRequest<TimeSlotDto>
    {
        public Guid TimeSlotId { get; set; }
    }
}

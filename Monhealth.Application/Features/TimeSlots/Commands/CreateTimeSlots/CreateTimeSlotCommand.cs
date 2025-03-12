using MediatR;

namespace Monhealth.Application.Features.TimeSlots.Commands.CreateTimeSlots
{
    public class CreateTimeSlotCommand : IRequest<Unit>
    {
        public TimeOnly StartTime { get; set; }

    }
}

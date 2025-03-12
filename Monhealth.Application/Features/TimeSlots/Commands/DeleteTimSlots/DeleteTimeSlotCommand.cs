using MediatR;

namespace Monhealth.Application.Features.TimeSlots.Commands.DeleteTimSlots
{
    public class DeleteTimeSlotCommand : IRequest<bool>
    {
        public Guid TimeSlotId { get; set; }
    }
}

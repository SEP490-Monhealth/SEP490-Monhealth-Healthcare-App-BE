using MediatR;

namespace Monhealth.Application.Features.TimeSlots.Commands.UpdateTimeSlots
{
    public class UpdateTimeSlotCommand : IRequest<bool>
    {
        public Guid TimeSlotId { get; set; }
        public UpdateTimeSlotDto TimeSlotDto { get; set; }

        public UpdateTimeSlotCommand(Guid timeSlotId, UpdateTimeSlotDto timeSlotDto)
        {
            TimeSlotId = timeSlotId;
            TimeSlotDto = timeSlotDto ?? throw new ArgumentNullException(nameof(timeSlotDto));
        }

    }
}

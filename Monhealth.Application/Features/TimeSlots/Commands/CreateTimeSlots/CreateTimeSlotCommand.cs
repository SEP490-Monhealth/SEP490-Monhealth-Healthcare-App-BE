using MediatR;

namespace Monhealth.Application.Features.TimeSlots.Commands.CreateTimeSlots
{
    public class CreateTimeSlotCommand : IRequest<Unit>
    {
        public CreateTimeSlotDTO CreateTimeSlotDTO { get; set; }
        public CreateTimeSlotCommand(CreateTimeSlotDTO createTimeSlotDTO)
        {
            CreateTimeSlotDTO = createTimeSlotDTO;
        }
    }
}

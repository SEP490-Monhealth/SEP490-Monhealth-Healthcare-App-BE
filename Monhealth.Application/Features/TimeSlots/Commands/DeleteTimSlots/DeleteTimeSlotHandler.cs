using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.TimeSlots.Commands.DeleteTimSlots
{
    public class DeleteTimeSlotHandler(ITimeSlotRepository timeSlotRepository) : IRequestHandler<DeleteTimeSlotCommand, bool>
    {
        public async Task<bool> Handle(DeleteTimeSlotCommand request, CancellationToken cancellationToken)
        {

            var timeSlot = await timeSlotRepository.GetByIdAsync(request.TimeSlotId);
            if (timeSlot == null) throw new BadRequestException("Không tìm thấy lịch");
            timeSlotRepository.Remove(timeSlot);
            await timeSlotRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}

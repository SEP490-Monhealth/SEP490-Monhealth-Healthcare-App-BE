using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.TimeSlots.Commands.UpdateTimeSlots
{
    public class UpdateTimeSlotCommandHandler(ITimeSlotRepository timeSlotRepository) : IRequestHandler<UpdateTimeSlotCommand, bool>
    {
        public async Task<bool> Handle(UpdateTimeSlotCommand request, CancellationToken cancellationToken)
        {
            var timeslot = await timeSlotRepository.GetByIdAsync(request.TimeSlotId);
            if (timeslot == null) throw new BadRequestException("Không tìm thấy khung giờ");
            if (timeslot.StartTime != request.TimeSlotDto.StartTime)
            {
                timeslot.StartTime = request.TimeSlotDto.StartTime;
                timeslot.EndTime = request.TimeSlotDto.EndTime;
                timeslot.UpdatedAt = DateTime.Now;
            }
            await timeSlotRepository.SaveChangeAsync(cancellationToken);
            return true;

        }
    }
}

using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain;

namespace Monhealth.Application.Features.TimeSlots.Commands.CreateTimeSlots
{
    public class CreateTimeSlotCommandHandler(ITimeSlotRepository timeSlotRepository) : IRequestHandler<CreateTimeSlotCommand, Unit>
    {
        public async Task<Unit> Handle(CreateTimeSlotCommand request, CancellationToken cancellationToken)
        {
            var existingTimeSlot = await timeSlotRepository.GetTimeSlotByStartTime(request.CreateTimeSlotDTO.StartTime);
            if (existingTimeSlot != null) throw new BadRequestException("Khung giờ này đã được tạo");
            var newTimslot = new TimeSlot
            {
                StartTime = request.CreateTimeSlotDTO.StartTime,
                EndTime = request.CreateTimeSlotDTO.StartTime,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            timeSlotRepository.Add(newTimslot);
            await timeSlotRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }

    }
}

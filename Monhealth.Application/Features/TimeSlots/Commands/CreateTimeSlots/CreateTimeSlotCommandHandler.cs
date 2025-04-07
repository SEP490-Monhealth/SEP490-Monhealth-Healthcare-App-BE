using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.TimeSlots.Commands.CreateTimeSlots
{
    public class CreateTimeSlotCommandHandler(ITimeSlotRepository timeSlotRepository,
        IScheduleRepository scheduleRepository,
        IScheduleTimeSlotRepository scheduleTimeSlotRepository
        ) : IRequestHandler<CreateTimeSlotCommand, Unit>
    {
        public async Task<Unit> Handle(CreateTimeSlotCommand request, CancellationToken cancellationToken)
        {
            var existingTimeSlot = await timeSlotRepository.GetTimeSlotByStartAndEndTime(request.CreateTimeSlotDTO.StartTime, request.CreateTimeSlotDTO.EndTime);
            var schedule = await scheduleRepository.GetScheduleByIdAsync(request.CreateTimeSlotDTO.ScheduleId);
            if (schedule == null) throw new BadRequestException("Lich không tìm thấy");
            TimeSlot timeSlotToUse;
            if (existingTimeSlot != null)
            {
                timeSlotToUse = existingTimeSlot;
            }
            else
            {
                timeSlotToUse = new TimeSlot
                {
                    TimeSlotId = Guid.NewGuid(),
                    StartTime = request.CreateTimeSlotDTO.StartTime,
                    EndTime = request.CreateTimeSlotDTO.EndTime,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                };
                timeSlotRepository.Add(timeSlotToUse);
            };

            //check scheduleTimeslot Isduplicate
            var isDuplicate = await scheduleTimeSlotRepository.ExistTimeSlot(schedule.ScheduleId, timeSlotToUse.TimeSlotId);

            if (isDuplicate)
            {
                throw new BadRequestException("Thời gian này đã được thêm vào lịch trước đó");
            }

            //add subtable scheduleTimeSlot
            var newScheduleTimeSlot = new ScheduleTimeSlot
            {
                ScheduleId = schedule.ScheduleId,
                TimeSlotId = timeSlotToUse.TimeSlotId,
                Status = ScheduleTimeSlotStatus.Available,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            scheduleTimeSlotRepository.Add(newScheduleTimeSlot);

            await timeSlotRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }

    }
}

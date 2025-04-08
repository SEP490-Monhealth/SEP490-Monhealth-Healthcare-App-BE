using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain;
using Monhealth.Domain.Enum;
namespace Monhealth.Application.Features.Schedule.Commands.Create
{
    public class CreateScheduleCommandHandler(ITimeSlotRepository timeSlotRepository, IScheduleRepository scheduleRepository, IScheduleTimeSlotRepository scheduleTimeSlotRepository) : IRequestHandler<CreateScheduleCommand, Unit>
    {
        public async Task<Unit> Handle(CreateScheduleCommand request, CancellationToken cancellationToken)
        {

            var schedules = new List<Domain.Schedule>();
            var allTimeSlotsToAdd = new List<TimeSlot>();
            var allScheduleTimeSlotsToAdd = new List<ScheduleTimeSlot>();
            foreach (var scheduleDto in request.Schedules)
            {
                if (scheduleDto.RecurringDay == null && scheduleDto.SpecificDate == null)
                {
                    throw new BadRequestException("RecurringDay và SpecificDate cả hai không được phép null");
                }

                //check has shedule by recuring type
                var existingSchedule = await scheduleRepository.GetScheduleAsync
                    (request.ConsultantId, request.ScheduleType,
                    scheduleDto?.RecurringDay,
                    scheduleDto?.SpecificDate
                    );

                Domain.Schedule scheduleToUse;
                if (existingSchedule != null)
                {
                    scheduleToUse = existingSchedule;
                }
                else
                {
                    scheduleToUse = new Domain.Schedule
                    {
                        ScheduleId = Guid.NewGuid(),
                        ConsultantId = request.ConsultantId,
                        ScheduleType = request.ScheduleType,
                        RecurringDay = scheduleDto.RecurringDay,
                        SpecificDate = scheduleDto.SpecificDate,
                        CreatedAt = DateTime.Now
                    };
                    schedules.Add(scheduleToUse);
                }

                // Parse TimeSlots from string to TimeOnly (Optimized logic here!)
                var parsedTimeSlots = scheduleDto?.TimeSlots.Select(ts =>
                {
                    var times = ts.Split("-", StringSplitOptions.TrimEntries);
                    return new
                    {
                        StartTime = TimeOnly.ParseExact(times[0], "HH:mm:ss"),
                        EndTime = TimeOnly.ParseExact(times[1], "HH:mm:ss")
                    };
                }).ToList();


                //check TimeSlot existed in Db
                var existingTimeSlots = await timeSlotRepository.GetExistTimeSlotByListTimeAsync(parsedTimeSlots.Select(ts => (ts.StartTime, ts.EndTime)).ToList());

                //create new timeslot 
                var newTimeSlots = parsedTimeSlots
                .Where(ts => !existingTimeSlots.Any(ets => ets.StartTime == ts.StartTime && ets.EndTime == ts.EndTime))
                .Select(ts => new TimeSlot
                {
                    TimeSlotId = Guid.NewGuid(),
                    StartTime = ts.StartTime,
                    EndTime = ts.EndTime,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                })
                .ToList();

                allTimeSlotsToAdd.AddRange(newTimeSlots);


                var allTimeSlots = existingTimeSlots.Concat(newTimeSlots).ToList();

                //add ScheduleTimeSlot table
                var existingScheduleTimeSlotIds = await scheduleTimeSlotRepository.GetTimslotIdsByScheduleId(scheduleToUse.ScheduleId);

                var scheduleTimeSlots = allTimeSlots
                    .Where(ts => !existingScheduleTimeSlotIds.Contains(ts.TimeSlotId)) //only add when it not exist
                    .Select(ts =>
                    new ScheduleTimeSlot
                    {
                        ScheduleId = scheduleToUse.ScheduleId,
                        TimeSlotId = ts.TimeSlotId,
                        Status = ScheduleTimeSlotStatus.Available,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,

                    }
                ).ToList();

                allScheduleTimeSlotsToAdd.AddRange(scheduleTimeSlots);

            }
            if (schedules.Any())
                scheduleRepository.AddRange(schedules);

            if (allTimeSlotsToAdd.Any())
                timeSlotRepository.AddRange(allTimeSlotsToAdd);

            if (allScheduleTimeSlotsToAdd.Any())
                scheduleTimeSlotRepository.AddRange(allScheduleTimeSlotsToAdd);

            await scheduleRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}

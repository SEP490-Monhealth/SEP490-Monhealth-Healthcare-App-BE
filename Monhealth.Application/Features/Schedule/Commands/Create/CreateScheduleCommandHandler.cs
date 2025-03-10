using MediatR;
namespace Monhealth.Application.Features.Schedule.Commands.Create
{
    public class CreateScheduleCommandHandler : IRequestHandler<CreateScheduleCommand, Unit>
    {
        public Task<Unit> Handle(CreateScheduleCommand request, CancellationToken cancellationToken)
        {
            var schedules = new List<Domain.Schedule>();
            foreach (var scheduleDto in request.Schedules)
            {
                var newSchedule = new Domain.Schedule
                {
                    ConsultantId = Guid.NewGuid(),
                    ScheduleType = request.ScheduleType,
                    RecurringDay = scheduleDto.RecurringDay,
                    SpecificDate = scheduleDto.SpecificDate,
                };

                //check TimeSlot existed in Db
                var existingTimeSlots =
            }
        }
    }
}

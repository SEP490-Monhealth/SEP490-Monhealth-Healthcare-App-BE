using MediatR;

namespace Monhealth.Application.Features.ScheduleException.Commands.UpdateScheduleException
{
    public class UpdateScheduleExceptionCommand : IRequest<Unit>
    {
        public Guid ScheduleExceptionId { get; set; }
        public UpdateScheduleExceptionDto UpdateScheduleExceptionDto { get; set; }

        public UpdateScheduleExceptionCommand(Guid scheduleExceptionId, UpdateScheduleExceptionDto updateScheduleExceptionDto)
        {
            ScheduleExceptionId = scheduleExceptionId;
            UpdateScheduleExceptionDto = updateScheduleExceptionDto;
        }
    }
}

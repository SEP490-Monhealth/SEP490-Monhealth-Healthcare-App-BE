using MediatR;

namespace Monhealth.Application.Features.ScheduleException.Commands.UpdateScheduleException
{
    public class UpdateScheduleExceptionCommand : IRequest<Unit>
    {
        public Guid ExceptionId { get; set; }
        public UpdateScheduleExceptionDto UpdateScheduleExceptionDto { get; set; }

        public UpdateScheduleExceptionCommand(Guid exceptionId, UpdateScheduleExceptionDto updateScheduleExceptionDto)
        {
            ExceptionId = exceptionId;
            UpdateScheduleExceptionDto = updateScheduleExceptionDto;
        }

    }
}

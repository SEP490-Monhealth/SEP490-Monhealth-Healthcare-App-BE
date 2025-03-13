using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.ScheduleException.Commands.UpdateScheduleException
{
    public class UpdateScheduleExceptionCommandHandler(IScheduleExceptionRepository scheduleExceptionRepository) : IRequestHandler<UpdateScheduleExceptionCommand, Unit>
    {
        public async Task<Unit> Handle(UpdateScheduleExceptionCommand request, CancellationToken cancellationToken)
        {
            var scheduleException = await scheduleExceptionRepository.GetByIdAsync(request.ExceptionId);
            if (scheduleException == null) throw new BadRequestException("Không tìm thấy lịch bận");
            if (scheduleException.ScheduleId != request.UpdateScheduleExceptionDto.ScheduleId)
            {
                scheduleException.ScheduleId = request.UpdateScheduleExceptionDto.ScheduleId;
            }
            if (scheduleException.Date != request.UpdateScheduleExceptionDto.Date)
            {
                scheduleException.Date = request.UpdateScheduleExceptionDto.Date;
            }
            if (scheduleException.Reason != request.UpdateScheduleExceptionDto.Reason)
            {
                scheduleException.Reason = request.UpdateScheduleExceptionDto.Reason;
            }
            scheduleException.UpdatedAt = DateTime.Now;
            await scheduleExceptionRepository.SaveChangeAsync(cancellationToken);
            return Unit.Value;
        }

    }
}

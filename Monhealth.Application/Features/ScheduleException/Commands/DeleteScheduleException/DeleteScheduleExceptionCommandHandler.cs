using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.ScheduleException.Commands.DeleteScheduleException
{
    public class DeleteScheduleExceptionCommandHandler(IScheduleExceptionRepository scheduleExceptionRepository) : IRequestHandler<DeleteScheduleExceptionCommand, bool>
    {
        public async Task<bool> Handle(DeleteScheduleExceptionCommand request, CancellationToken cancellationToken)
        {
            var scheduleException = await scheduleExceptionRepository.GetByIdAsync(request.ExceptionId);
            if (scheduleException == null) throw new BadRequestException("Không tìm thấy lịch bận");
            scheduleExceptionRepository.Remove(scheduleException);
            await scheduleExceptionRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}

using MediatR;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.ScheduleException.Commands.UpdateExceptionRejectedStatus
{
    public class UpdateExceptionRejectedCommandHandler(IScheduleExceptionRepository scheduleExceptionRepository,
        ISystemNotificationService systemNotificationService,
        IConsultantRepository consultantRepository
        ) : IRequestHandler<UpdateExceptionRejectedStatusCommand, bool>
    {
        public async Task<bool> Handle(UpdateExceptionRejectedStatusCommand request, CancellationToken cancellationToken)
        {
            var scheduleExeption = await scheduleExceptionRepository.GetScheduleExceptionByIdAsync(request.ScheduleExceptionId)
            ?? throw new BadRequestException($"Không tìm thấy lịch bận {request.ScheduleExceptionId}");

            var consultant = await consultantRepository.GetByIdAsync(scheduleExeption.ConsultantId)
            ?? throw new BadRequestException($"Không tìm thấy tư vấn viên {scheduleExeption.ConsultantId}");

            //Notify consultant
            await systemNotificationService.SendRejectedScheduleExceptionForConsultant(consultant, cancellationToken);

            scheduleExeption.Status = ScheduleExceptionStatus.Rejected;
            await scheduleExceptionRepository.SaveChangeAsync(cancellationToken);
            return true;
        }
    }
}

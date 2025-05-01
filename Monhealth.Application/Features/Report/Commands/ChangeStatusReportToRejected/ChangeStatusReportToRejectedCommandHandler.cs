using MediatR;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Report.Commands.ChangeStatusReportToRejected
{
    public class ChangeStatusReportToRejectedCommandHandler(IReportRepository reportRepository,
        ISystemNotificationService systemNotificationService
        ) : IRequestHandler<ChangeStatusReportToRejectedCommand, bool>
    {
        public async Task<bool> Handle(ChangeStatusReportToRejectedCommand request, CancellationToken cancellationToken)
        {
            var report = await reportRepository.GetByIdAsync(request.ReportId);
            if (report == null)
            {
                return false;
            }
            if (report.Status == StatusReport.Pending)
            {
                report.Status = StatusReport.Rejected;
            }
            else
            {
                throw new Exception($"Không thể từ chối, trạng thái đang là {report.Status}.");
            }
            report.UpdatedAt = GetCurrentVietnamTime();
            reportRepository.Update(report);
            await reportRepository.SaveChangeAsync();

            //Notify user
            await systemNotificationService.NotifyUserReportRejectedAsync(report, cancellationToken);
            return true;
        }
        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }
    }
}

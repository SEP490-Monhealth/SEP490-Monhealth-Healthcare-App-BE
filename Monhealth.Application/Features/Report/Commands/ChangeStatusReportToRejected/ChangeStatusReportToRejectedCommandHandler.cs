using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Report.Commands.ChangeStatusReportToRejected
{
    public class ChangeStatusReportToRejectedCommandHandler(IReportRepository reportRepository) : IRequestHandler<ChangeStatusReportToRejectedCommand, bool>
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
            reportRepository.Update(report);
            await reportRepository.SaveChangeAsync();
            return true;
        }
    }
}

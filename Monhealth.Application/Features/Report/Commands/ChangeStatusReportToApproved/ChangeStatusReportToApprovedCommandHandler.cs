using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Report.Commands.ChangeStatusReportToApproved
{
    public class ChangeStatusReportToApprovedCommandHandler(IReportRepository reportRepository) : IRequestHandler<ChangeStatusReportToApprovedCommand, bool>
    {
        public async Task<bool> Handle(ChangeStatusReportToApprovedCommand request, CancellationToken cancellationToken)
        {
            var report = await reportRepository.GetByIdAsync(request.ReportId);
            if (report == null)
            {
                return false;
            }
            if (report.Status == StatusReport.Pending)
            {
                report.Status = StatusReport.Approved;
            }
            else
            {
                throw new Exception($"Không thể chấp nhận, trạng thái đang là {report.Status}.");
            }
            reportRepository.Update(report);
            await reportRepository.SaveChangeAsync();
            return true;
        }
    }
}

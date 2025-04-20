using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Report.Commands.DeleteReport
{
    public class DeleteReportCommandHandler(IReportRepository reportRepository) : IRequestHandler<DeleteReportCommand, bool>
    {
        public async Task<bool> Handle(DeleteReportCommand request, CancellationToken cancellationToken)
        {
            var report = await reportRepository.GetByIdAsync(request.ReportId);
            if (report == null)
            {
                return false;
            }
            reportRepository.Remove(report);
            await reportRepository.SaveChangeAsync();
            return true;
        }
    }
}

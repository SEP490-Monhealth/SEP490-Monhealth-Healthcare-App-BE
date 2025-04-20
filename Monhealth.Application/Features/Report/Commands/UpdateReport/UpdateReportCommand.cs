using MediatR;

namespace Monhealth.Application.Features.Report.Commands.UpdateReport
{
    public class UpdateReportCommand : IRequest<bool>
    {
        public Guid ReportId { get; set; }
        public UpdateReportDTO UpdateReportDTO { get; set; }
        public UpdateReportCommand(Guid reportId, UpdateReportDTO updateReportDTO)
        {
            ReportId = reportId;
            UpdateReportDTO = updateReportDTO;
        }
    }
}

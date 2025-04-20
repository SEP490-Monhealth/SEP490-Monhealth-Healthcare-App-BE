using MediatR;

namespace Monhealth.Application.Features.Report.Commands.DeleteReport
{
    public class DeleteReportCommand : IRequest<bool>
    {
        public Guid ReportId { get; set; }
    }
}

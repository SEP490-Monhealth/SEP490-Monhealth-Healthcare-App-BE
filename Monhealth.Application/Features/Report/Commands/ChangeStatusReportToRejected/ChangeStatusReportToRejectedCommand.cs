using MediatR;

namespace Monhealth.Application.Features.Report.Commands.ChangeStatusReportToRejected
{
    public class ChangeStatusReportToRejectedCommand : IRequest<bool>
    {
        public Guid ReportId { get; set; }
    }
}

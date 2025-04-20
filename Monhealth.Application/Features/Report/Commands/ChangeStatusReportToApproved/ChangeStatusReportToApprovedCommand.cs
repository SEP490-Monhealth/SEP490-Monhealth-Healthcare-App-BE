using MediatR;

namespace Monhealth.Application.Features.Report.Commands.ChangeStatusReportToApproved
{
    public class ChangeStatusReportToApprovedCommand : IRequest<bool>
    {
        public Guid ReportId { get; set; }
    }
}

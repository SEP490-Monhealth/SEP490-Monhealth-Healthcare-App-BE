using MediatR;

namespace Monhealth.Application.Features.Report.Queries.GetReportById
{
    public class GetReportByIdQuery : IRequest<GetReportByIdDTO>
    {
        public Guid ReportId { get; set; }
    }
}

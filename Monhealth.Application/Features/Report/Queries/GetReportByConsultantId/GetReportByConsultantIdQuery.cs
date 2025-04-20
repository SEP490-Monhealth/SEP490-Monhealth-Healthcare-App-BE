using MediatR;

namespace Monhealth.Application.Features.Report.Queries.GetReportByConsultantId
{
    public class GetReportByConsultantIdQuery : IRequest<List<GetReportByConsultantIdDTO>>
    {
        public Guid ConsultantId { get; set; }
    }
}

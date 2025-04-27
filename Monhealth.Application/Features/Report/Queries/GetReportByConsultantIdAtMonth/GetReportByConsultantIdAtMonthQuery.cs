using MediatR;

namespace Monhealth.Application.Features.Report.Queries.GetReportByConsultantIdAtMonth
{
    public class GetReportByConsultantIdAtMonthQuery : IRequest<List<GetReportByConsultantIdAtMonthDTO>>
    {
        public Guid ConsultantId { get; set; }
        public string Month { get; set; } 
    }
}

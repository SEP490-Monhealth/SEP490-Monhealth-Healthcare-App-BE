using MediatR;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Report.Queries.GetReportByConsultantId
{
    public class GetReportByConsultantIdQuery : IRequest<PageResult<GetReportByConsultantIdDTO>>
    {

        public Guid ConsultantId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public GetReportByConsultantIdQuery(Guid consultantId, int page, int limit)
        {
            ConsultantId = consultantId;
            Page = page;
            Limit = limit;
        }
        
    }
}

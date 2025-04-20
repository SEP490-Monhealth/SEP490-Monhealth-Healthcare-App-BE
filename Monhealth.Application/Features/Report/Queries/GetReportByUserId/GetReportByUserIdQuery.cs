using MediatR;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Report.Queries.GetReportByUserId
{
    public class GetReportByUserIdQuery : IRequest<PageResult<GetReportByUserIdDTO>>
    {
      public Guid UserId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public GetReportByUserIdQuery(Guid userId, int page, int limit)
        {
            UserId= userId;
            Page = page;
            Limit = limit;
        }
    }
}

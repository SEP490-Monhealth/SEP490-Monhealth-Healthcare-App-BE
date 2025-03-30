using MediatR;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Transaction.Queries.GetTransactionByConsultantId
{
    public class GetTransactionByConsultantIdQuery : IRequest<PageResult<GetTransactionByConsultantIdDTO>>
    {
        public Guid ConsultantId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public GetTransactionByConsultantIdQuery(Guid consultant, int page, int limit)
        {
            ConsultantId = consultant;
            Page = page;
            Limit = limit;
        }

    }
}

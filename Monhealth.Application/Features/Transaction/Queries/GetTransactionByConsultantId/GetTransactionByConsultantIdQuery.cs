using MediatR;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Transaction.Queries.GetTransactionByConsultantId
{
    public class GetTransactionByConsultantIdQuery : IRequest<PageResult<GetTransactionByConsultantIdDTO>>
    {
        public Guid ConsultantId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
        public StatusTransaction? Status { get; set; }
        public GetTransactionByConsultantIdQuery(Guid consultant, int page, int limit, StatusTransaction? status)
        {
            ConsultantId = consultant;
            Page = page;
            Limit = limit;
            Status = status;
        }

    }
}

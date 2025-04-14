using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Transaction.Queries.GetTransactionByCreatedBy
{
    public class GetTransactionByCreatedByQuery : IRequest<PageResult<GetTransactionByCreatedByDTO>>
    {
        public Guid UserId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
    }
}

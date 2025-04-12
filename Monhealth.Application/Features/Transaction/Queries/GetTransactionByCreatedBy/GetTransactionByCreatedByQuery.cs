using MediatR;

namespace Monhealth.Application.Features.Transaction.Queries.GetTransactionByCreatedBy
{
    public class GetTransactionByCreatedByQuery : IRequest<List<GetTransactionByCreatedByDTO>>
    {
        public Guid UserId { get; set; }
    }
}

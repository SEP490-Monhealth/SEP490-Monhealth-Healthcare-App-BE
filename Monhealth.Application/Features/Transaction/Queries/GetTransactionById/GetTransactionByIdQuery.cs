using MediatR;

namespace Monhealth.Application.Features.Transaction.Queries.GetTransactionById
{
    public class GetTransactionByIdQuery : IRequest<GetTransactionByIdDTO>
    {
        public Guid TransactionId { get; set; }
    }
}

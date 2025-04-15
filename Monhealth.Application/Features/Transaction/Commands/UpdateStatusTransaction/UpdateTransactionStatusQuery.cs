using MediatR;

namespace Monhealth.Application.Features.Transaction.Commands.UpdateTransaction
{
    public class UpdateTransactionStatusQuery : IRequest<bool>
    {
        public Guid TransactionId { get; set; }
    }
}

using MediatR;

namespace Monhealth.Application.Features.Transaction.Commands.DeleteTransaction
{
    public class DeleteTransactionCommand : IRequest<bool>
    {
        public Guid TransactionId { get; set; }
    }
}

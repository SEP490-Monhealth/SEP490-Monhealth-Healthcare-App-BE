using MediatR;

namespace Monhealth.Application.Features.Transaction.Commands.UpdateTransaction
{
    public class UpdateTransactionCommand : IRequest<bool>
    {
        public UpdateTransactionDTO UpdateTransactionDTO { get; set; }
        public Guid TransactionId { get; set; }
        public UpdateTransactionCommand(Guid transactionId 
        ,UpdateTransactionDTO updateTransactionDTO)
        {
            UpdateTransactionDTO = updateTransactionDTO;
            TransactionId = transactionId;
        }
    }
}

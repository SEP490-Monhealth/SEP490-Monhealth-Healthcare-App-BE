using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Transaction.Commands.UpdateTransaction
{
    public class UpdateTransactionCommand : IRequest<bool>
    {
        public Guid TransactionId { get; set; }
        public UpdateTransactionDTO UpdateTransactionDTO { get; set; }
        public UpdateTransactionCommand(Guid transactionId, UpdateTransactionDTO updateTransactionDTO)
        {
            TransactionId = transactionId;
            UpdateTransactionDTO = updateTransactionDTO;
        }
    }
}

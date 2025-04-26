using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class TransactionStatusByTransactionDTO
    {
        public StatusTransaction statusTransaction { get; set; }
    }
    public class GetTransactionStatusByTransactionQuery : IRequest<TransactionStatusByTransactionDTO>
    {
        public Guid TransactionId { get; set; }
    }
    public class GetTransactionStatusByTransactionQueryHandler(ITransactionRepository _transactionRepository) : IRequestHandler<GetTransactionStatusByTransactionQuery, TransactionStatusByTransactionDTO>
    {
        public async Task<TransactionStatusByTransactionDTO> Handle(GetTransactionStatusByTransactionQuery request, CancellationToken cancellationToken)
        {
            var transaction = await _transactionRepository.GetByIdAsync(request.TransactionId);
            return new TransactionStatusByTransactionDTO
            {
                statusTransaction = transaction.Status ?? default(StatusTransaction)
            };
        }
    }
}
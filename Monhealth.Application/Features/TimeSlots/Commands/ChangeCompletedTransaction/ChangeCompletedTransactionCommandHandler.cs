using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.TimeSlots.Commands.ChangeCompletedTransaction
{
    public class ChangeCompletedTransactionCommandHandler(ITransactionRepository transactionRepository) : IRequestHandler<ChangeCompletedTransactionCommand, bool>
    {
        public async Task<bool> Handle(ChangeCompletedTransactionCommand request, CancellationToken cancellationToken)
        {
            var transaction = await transactionRepository.GetByIdAsync(request.transactionId);
            if (transaction == null)
            {
                return false;
            }
            if (transaction.Status == StatusTransaction.Completed || transaction.Status == StatusTransaction.Failed)
            {
                throw new Exception($"Không thể cập nhật vì đang là trạng thái {transaction.Status}");
            }
            transaction.Status = StatusTransaction.Completed;
            transactionRepository.Update(transaction);
            await transactionRepository.SaveChangeAsync();
            return true;
        }
    }
}

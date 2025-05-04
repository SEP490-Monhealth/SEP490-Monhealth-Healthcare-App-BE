using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class UpdateStatusFailedCommand : IRequest<bool>
    {
        public Guid TransactionId { get; set; }
    }
    public class UpdateStatusFailedCommandHandler : IRequestHandler<UpdateStatusFailedCommand, bool>
    {
        private readonly ITransactionRepository _transactionRepository;

        public UpdateStatusFailedCommandHandler(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task<bool> Handle(UpdateStatusFailedCommand request, CancellationToken cancellationToken)
        {
            var transaction = await _transactionRepository.GetByIdAsync(request.TransactionId);
            if (transaction == null) throw new Exception("Giao dịch không tồn tại");
            if (transaction.Status == StatusTransaction.Pending)
            {
                transaction.Status = StatusTransaction.Failed;
            }
            else if (transaction.Status == StatusTransaction.Completed)
            {
                throw new Exception("Giao dich đã hoàn thành không thể thay đổi trạng thái");
            }
            await _transactionRepository.SaveChangeAsync();
            return true;
        }
    }

}
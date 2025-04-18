using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Withdrawal.Commands.ChangeToApproveStatus
{
    public class ChangeToApproveStatusCommandHandler(IWithdrawalRepository withdrawalRepository,
            ITransactionRepository transactionRepository
        ) : IRequestHandler<ChangeToApproveStatusCommand, bool>
    {
        public async Task<bool> Handle(ChangeToApproveStatusCommand request, CancellationToken cancellationToken)
        {
            var withdrawalRequest = await withdrawalRepository.GetWithdrawalRequest(request.WithdrawalRequestId);

            if (withdrawalRequest == null)
            {
                throw new Exception("Yêu cầu rút tiền không tồn tại.");
            }
            if (withdrawalRequest.Status == WithdrawalStatus.Pending)
            {
                withdrawalRequest.Status = WithdrawalStatus.Approved;
            }
            else
            {
                throw new Exception("Không thể Cập nhật trạng thái");
            }

            //added transaction record
            var newTransaction = new Domain.Transaction
            {
                TransactionId = Guid.NewGuid(),
                WalletId = withdrawalRequest.Consultant?.Wallet?.WalletId ?? Guid.Empty,
                UserId = withdrawalRequest.ConsultantId,
                TransactionType = TransactionType.Withdrawal,
                Amount = withdrawalRequest.Amount,
                Description = withdrawalRequest?.Description ?? "Rút tiền từ ví",
                Status = StatusTransaction.Pending,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                WithdrawalRequestId = withdrawalRequest.WithdrawalRequestId,
            };
            transactionRepository.Add(newTransaction);

            withdrawalRepository.Update(withdrawalRequest);
            await withdrawalRepository.SaveChangeASync();
            return true;
        }
    }
}

using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class UpdateStatusWithdrawalCommandHandler(IWithdrawalRepository withdrawalRepository, 
                                                      IWalletRepository walletRepository,
                                                      ITransactionRepository transactionRepository) : IRequestHandler<UpdateStatusWithdrawalCommand, Unit>
    {
        public async Task<Unit> Handle(UpdateStatusWithdrawalCommand request, CancellationToken cancellationToken)
        {
            var withdrawalRequest = await withdrawalRepository.GetByIdAsync(request.WithdrawalRequestId);
            switch (withdrawalRequest.Status) // Assuming 'Status' is the property to check
            {
                case WithdrawalStatus.Pending:
                    withdrawalRequest.Status = WithdrawalStatus.Approved;
                    break;
                case WithdrawalStatus.Approved:
                    withdrawalRequest.Status = WithdrawalStatus.Completed;
                    var getWallet = await walletRepository.GetWalletByConsultantId(withdrawalRequest.ConsultantId);
                    var newTransaction = new Transaction
                    {
                        TransactionId = Guid.NewGuid(),
                        WalletId = getWallet.WalletId,
                        BookingId = null,
                        TransactionType = TransactionType.Withdrawal,
                        Amount = withdrawalRequest?.Amount ?? 0,
                        Description = withdrawalRequest?.Description ?? "Rút tiền về ngân hàng",
                        Status = StatusTransaction.Completed,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    };
                    transactionRepository.Add(newTransaction);
                    break;
                case WithdrawalStatus.Completed:
                    throw new Exception("Yêu cầu đã hoàn tất, không thể xử lý thêm.");
                default:
                    throw new Exception("Trạng thái yêu cầu không hợp lệ");
            }
            withdrawalRepository.Update(withdrawalRequest);
            await withdrawalRepository.SaveChangeASync();
            return Unit.Value;
        }
    }
}
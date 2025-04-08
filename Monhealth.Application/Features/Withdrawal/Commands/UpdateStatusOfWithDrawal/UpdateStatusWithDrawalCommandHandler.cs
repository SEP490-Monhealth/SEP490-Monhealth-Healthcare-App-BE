using MediatR;
using Monhealth.Application.Contracts.Persistence;
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
                //case WithdrawalStatus.Pending:
                //    withdrawalRequest.Status = WithdrawalStatus.Approved;
                //    break;
                case WithdrawalStatus.Approved:
                    //trừ tiền
                    var wallet = await walletRepository.GetWalletByConsultantId(withdrawalRequest.ConsultantId);
                    if (wallet == null) throw new Exception("Không tìm thấy ví của người dùng.");
                    if (wallet.Balance < withdrawalRequest.Amount)
                        throw new Exception("Số dư không đủ để rút.");
                    wallet.Balance -= withdrawalRequest.Amount;

                    //update transaction 
                    var transaction = await transactionRepository.GetTransactionWhenUpdated(TransactionType.Withdrawal, withdrawalRequest.Amount, StatusTransaction.Pending);
                    if (transaction == null) throw new Exception("Không tìm thấy giao dịch");

                    transaction.Status = StatusTransaction.Completed;
                    withdrawalRequest.Status = WithdrawalStatus.Completed;
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
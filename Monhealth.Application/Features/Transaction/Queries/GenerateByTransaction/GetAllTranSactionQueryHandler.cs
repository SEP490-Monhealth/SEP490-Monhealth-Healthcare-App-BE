using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class GetAllTranSactionQueryHandler(
        ITransactionRepository transactionRepository,
        IWithdrawalRepository withdrawalRepository,
        IConsultantBankRepository consultantBankRepository)
        : IRequestHandler<GenerateTransactionQRCode, ResponseForTransaction>
    {
        public async Task<ResponseForTransaction> Handle(GenerateTransactionQRCode request, CancellationToken cancellationToken)
        {
            var transaction = await transactionRepository.GetByIdAsync(request.TransactionId);
            
            // Kiểm tra trạng thái giao dịch
            if (!transaction.TransactionType.Equals(TransactionType.Withdrawal))
            {
                throw new BadRequestException("Transaction type is not withdrawal.");
            }

            // Lấy thông tin Withdrawal, đảm bảo không null
            var withdrawal = transaction.WithdrawalRequestId.HasValue
                ? await withdrawalRepository.GetWithdrawalRequest(transaction.WithdrawalRequestId.Value)
                : throw new ArgumentNullException(nameof(transaction.WithdrawalRequestId), "WithdrawalRequestId cannot be null");

            // Kiểm tra trạng thái của withdrawal
            if (withdrawal.Status != Domain.Enum.WithdrawalStatus.Approved)
            {
                throw new BadRequestException("Yêu cầu rút tiền này không ở trạng thái chờ xử lý");
            }

            // Lấy dữ liệu consultantBank và kiểm tra null trước khi sử dụng
            var consultantBank = await consultantBankRepository.GetConsultantBankById(withdrawal.ConsultantBankId);
            if (consultantBank == null)
            {
                throw new Exception("Không tìm thấy ngân hàng mặc định.");
            }

            var description = withdrawal.Description;
            var accountName = consultantBank.AccountName;
            var bankCode = consultantBank.Bank.BankCode;
            var accountNumber = consultantBank.AccountNumber;

            // Generate VietQR URL
            var qrUrl = $"https://img.vietqr.io/image/{bankCode}-{accountNumber}-compact2.png"
                + $"?amount={withdrawal.Amount}"
                + $"&addInfo={Uri.EscapeDataString(description)}"
                + $"&accountName={Uri.EscapeDataString(accountName)}";

            var bankName = $"{withdrawal.Consultant.ConsultantBanks.Select(cb => cb.Bank.ShortName).First()} - {withdrawal.Consultant.ConsultantBanks.Select(cb => cb.Bank.BankName).First()}";

            return new ResponseForTransaction(
                qrUrl,
                bankName,
                accountName,
                withdrawal.Amount,
                description
            );
        }
    }
}

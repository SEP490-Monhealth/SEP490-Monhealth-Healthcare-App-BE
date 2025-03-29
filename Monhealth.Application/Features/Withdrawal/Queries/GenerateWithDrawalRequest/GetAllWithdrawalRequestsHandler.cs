using MediatR;

namespace Monhealth.Application.Features.Withdrawal.Queries.GenerateWithdrawalRequest
{
    public class GetAllWithdrawalRequestsHandler(IWithdrawalRepository withdrawalRepository) : IRequestHandler<GenerateWithdrawalQRCode, Response>
    {
        public async Task<Response> Handle(GenerateWithdrawalQRCode request, CancellationToken cancellationToken)
        {
            var withdrawal = await withdrawalRepository.GetWithdrawalRequest(request.WithdrawalRequestId);
            if (withdrawal == null)
            {
                throw new Exception("Không tìm thấy yêu cầu rút tiền.");
            }
            if (withdrawal.Status != Domain.Enum.WithdrawalStatus.Approved)
            {
                throw new Exception("Yêu cầu rút tiền này không ở trạng thái chờ xử lý");

            }
            var defaultBank = withdrawal.Consultant.ConsultantBanks.FirstOrDefault(cb => cb.IsDefault);

            var description = withdrawal.Description;
            var accountName = defaultBank.AccountName;
            if (defaultBank == null)
            {
                throw new Exception("Không tìm thấy ngân hàng mặc định.");
            }

            var bankCode = defaultBank.Bank.BankCode;
            var accountNumber = defaultBank.AccountNumber;
            // Generate VietQR URL
            var qrUrl =
            $"https://img.vietqr.io/image/{bankCode}-{accountNumber}-compact2.png"
                + $"?amount={withdrawal.Amount}"
                + $"&addInfo={Uri.EscapeDataString(description)}"
                + $"&accountName={Uri.EscapeDataString(accountName)}";

            var bankName =
                $"{withdrawal.Consultant.ConsultantBanks.Select(cb => cb.Bank.ShortName).First()} - {withdrawal.Consultant.ConsultantBanks.Select(cb => cb.Bank.BankName).First()}";

            return new(
                           qrUrl,
                           bankName,
                           accountName,
                           withdrawal.Amount,
                           description
                       );
        }
    }
}
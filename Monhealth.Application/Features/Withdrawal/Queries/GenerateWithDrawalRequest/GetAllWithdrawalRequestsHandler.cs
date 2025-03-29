using MediatR;

namespace Monhealth.Application.Features.Withdrawal.Queries.GenerateWithDrawalRequest
{
    public class GetAllWithdrawalRequestsHandler(IWithDrawalRepository withDrawalRepository) : IRequestHandler<GenerateWithdrawalQRCode, Response>
    {
        public async Task<Response> Handle(GenerateWithdrawalQRCode request, CancellationToken cancellationToken)
        {
            var withDrawal = await withDrawalRepository.GetWithDrawalRequest(request.WithDrawalRequestId);
            if (withDrawal == null)
            {
                throw new Exception("Không tìm thấy yêu cầu rút tiền.");
            }
            if (withDrawal.Status != Domain.Enum.WithDrawalStatus.Approved)
            {
                throw new Exception("Yêu cầu rút tiền này không ở trạng thái chờ xử lý");

            }
            var defaultBank = withDrawal.Consultant.ConsultantBanks.FirstOrDefault(cb => cb.IsDefault);
            
            var description = withDrawal.Description;
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
                + $"?amount={withDrawal.Amount}"
                + $"&addInfo={Uri.EscapeDataString(description)}"
                + $"&accountName={Uri.EscapeDataString(accountName)}";

            var bankName =
                $"{withDrawal.Consultant.ConsultantBanks.Select(cb => cb.Bank.ShortName).First()} - {withDrawal.Consultant.ConsultantBanks.Select(cb => cb.Bank.BankName).First()}";

            return new(
                           qrUrl,
                           bankName,
                           accountName,
                           withDrawal.Amount,
                           description
                       );
        }
    }
}
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
            if (withDrawal.Status != Domain.Enum.WithDrawalStatus.Pending)
            {
                throw new Exception("Yêu cầu rút tiền này không ở trạng thái chờ xử lý");

            }
            var description = $"Consultant rut tien";
            var defaultBank = withDrawal.Consultant.ConsultantBanks.FirstOrDefault(cb => cb.IsDefault);

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
                + $"&accountName={Uri.EscapeDataString(withDrawal.Consultant.ConsultantBanks
                .Select(cb => cb.Bank.BankName).First())}";

            var bankName =
                $"{withDrawal.Consultant.ConsultantBanks.Select(cb => cb.Bank.BankName).First()} - {withDrawal.Consultant.ConsultantBanks.Select(cb => cb.Bank.BankName).First()}";

            return new(
                           qrUrl,
                           bankName,
                           withDrawal.Consultant.ConsultantBanks.Select(cb => cb.Bank.BankName).First(),
                           withDrawal.Amount,
                           description
                       );
        }
    }
}
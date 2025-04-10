using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Withdrawal.Queries.GenerateWithdrawalRequest
{
    public class GetAllWithdrawalRequestsHandler(IWithdrawalRepository withdrawalRepository,
        IConsultantBankRepository consultantBankRepository
        ) : IRequestHandler<GenerateWithdrawalQRCode, Response>
    {
        public async Task<Response> Handle(GenerateWithdrawalQRCode request, CancellationToken cancellationToken)
        {
            var withdrawal = await withdrawalRepository.GetWithdrawalRequest(request.WithdrawalRequestId);
            if (withdrawal == null)
            {
                throw new BadRequestException("Không tìm thấy yêu cầu rút tiền.");
            }
            if (withdrawal.Status != Domain.Enum.WithdrawalStatus.Approved)
            {
                throw new BadRequestException("Yêu cầu rút tiền này không ở trạng thái chờ xử lý");

            }
            var consultantBank = await consultantBankRepository.GetConsultantBankById(withdrawal.ConsultantBankId);

            var description = withdrawal.Description;
            var accountName = consultantBank.AccountName;
            if (consultantBank == null)
            {
                throw new Exception("Không tìm thấy ngân hàng mặc định.");
            }

            var bankCode = consultantBank.Bank.BankCode;
            var accountNumber = consultantBank.AccountNumber;
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
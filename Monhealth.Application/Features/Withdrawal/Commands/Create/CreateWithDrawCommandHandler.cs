using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain;

namespace Monhealth.Application
{
    public class CreateWithDrawCommandHandler(IWithdrawalRepository withdrawalRepository,
                                                IWalletRepository walletRepository,
                                                IConsultantBankRepository consultantBankRepository
        ) : IRequestHandler<CreateWithdrawalRequestDTO, bool>
    {
        public async Task<bool> Handle(CreateWithdrawalRequestDTO request, CancellationToken cancellationToken)
        {
            var wallet = await walletRepository.GetWalletByConsultantId(request.ConsultantId);

            if (wallet == null)
            {
                throw new BadRequestException("Không tìm thấy ví của chuyên viên tư vấn");
            }

            if (wallet.Balance < request.Amount)
            {
                throw new BadRequestException("Số dư không đủ để tạo yêu cầu rút tiền");
            };

            //check permission request with pendingRequest at a time
            var pendingWithdrawalRequests = await withdrawalRepository.GetAllWithdrawalRequestWithPendingStatus(request.ConsultantId);
            if (pendingWithdrawalRequests.Count() > 0)
            {
                throw new BadRequestException("Bạn chỉ có thể tạo một yêu cầu rút tiền trong một thời điểm");

            }

            float waitingMoney = 0;
            var withdrawalRequests = await withdrawalRepository.GetAllWithdrawalRequestWithPendingStatus(request.ConsultantId);
            waitingMoney = withdrawalRequests.Sum(x => x.Amount);
            if ((wallet.Balance - waitingMoney) < request.Amount)
            {
                throw new BadRequestException("Số dư không để để tạo yêu cầu rút tiền");
            }

            var consultantBank = await consultantBankRepository.GetConsultantBankById(request.ConsultantBankId);
            if (consultantBank == null) throw new BadRequestException("Không tìm thấy tài khoản ngân hàng của chuyên viên tư vấn");

            WithdrawalRequest model = new WithdrawalRequest
            {
                WithdrawalRequestId = Guid.NewGuid(),
                Amount = request.Amount,
                ConsultantId = request.ConsultantId,
                ConsultantBankId = request.ConsultantBankId,
                Description = request.Description,
                Status = Domain.Enum.WithdrawalStatus.Pending,
                CreatedAt = GetCurrentVietnamTime(),
                UpdatedAt = GetCurrentVietnamTime()
            };
            withdrawalRepository.Add(model);
            await withdrawalRepository.SaveChangeASync();
            return true;
        }
        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }
    }
}
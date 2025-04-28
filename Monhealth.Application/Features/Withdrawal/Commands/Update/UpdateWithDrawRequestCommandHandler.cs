using MediatR;

namespace Monhealth.Application
{
    public class UpdateWithDrawRequestCommandHandler(IWithdrawalRepository withdrawalRepository) : IRequestHandler<UpdateWithdrawalRequest, bool>
    {
        public async Task<bool> Handle(UpdateWithdrawalRequest request, CancellationToken cancellationToken)
        {
            var withdrawalRequest = await withdrawalRepository.GetByIdAsync(request.WithdrawalRequestId);
            if (withdrawalRequest == null)
            {
                throw new Exception($"Không tìm thấy yêu cầu rút tiền");
            }

            withdrawalRequest.ConsultantBankId = request.Request.ConsultantBankId;
            withdrawalRequest.Amount = request.Request.Amount;
            withdrawalRequest.Description = request.Request.Description;
            withdrawalRequest.UpdatedAt = GetCurrentVietnamTime();
            withdrawalRepository.Update(withdrawalRequest);
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
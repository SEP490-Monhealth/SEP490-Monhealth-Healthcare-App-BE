using MediatR;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class CancelWithdrawalStatusCommandHandler(IWithdrawalRepository withdrawalRepository) : IRequestHandler<CancelWithdrawalStatusCommand, Unit>
    {
        public async Task<Unit> Handle(CancelWithdrawalStatusCommand request, CancellationToken cancellationToken)
        {
            var status = await withdrawalRepository.GetByIdAsync(request.WithdrawalRequestId);

            if (status == null)
            {
                throw new Exception("Yêu cầu rút tiền không tồn tại.");
            }

            if (status.Status != WithdrawalStatus.Pending)
            {
                throw new Exception("Chỉ có yêu cầu ở trạng thái 'Pending' mới được phép từ chối.");
            }
            status.Reason = request.CancelWithdrawalStatusDTO.Reason;
            status.Status = WithdrawalStatus.Rejected;
            status.UpdatedAt = GetCurrentVietnamTime();
            withdrawalRepository.Update(status);
            await withdrawalRepository.SaveChangeASync();

            return Unit.Value;
        }
        private DateTime GetCurrentVietnamTime()
        {
            DateTime utcNow = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
            return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
        }
    }
}
using MediatR;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Withdrawal.Commands.ChangeToApproveStatus
{
    public class ChangeToApproveStatusCommandHandler(IWithdrawalRepository withdrawalRepository) : IRequestHandler<ChangeToApproveStatusCommand, bool>
    {
        public async Task<bool> Handle(ChangeToApproveStatusCommand request, CancellationToken cancellationToken)
        {
            var withdrawalRequest = await withdrawalRepository.GetByIdAsync(request.WithdrawalRequestId);
            if (withdrawalRequest == null)
            {
                throw new Exception("Yêu cầu rút tiền không tồn tại.");
            }
            if(withdrawalRequest.Status == WithdrawalStatus.Pending)
            {
                withdrawalRequest.Status = WithdrawalStatus.Approved;
            } else
            {
                throw new Exception("Không thể Cập nhật trạng thái");
            }
            withdrawalRepository.Update(withdrawalRequest);
            await withdrawalRepository.SaveChangeASync();
            return true;
        }
    }
}

using MediatR;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class CancelWithDrawalStatusCommandHandler(IWithdrawalRepository withDrawalRepository) : IRequestHandler<CancelWithDrawalStatusCommand, Unit>
    {
        public async Task<Unit> Handle(CancelWithDrawalStatusCommand request, CancellationToken cancellationToken)
        {
            var status = await withDrawalRepository.GetByIdAsync(request.WithDrawalRequestId);

            if (status == null)
            {
                throw new Exception("Yêu cầu rút tiền không tồn tại.");
            }

            if (status.Status != WithdrawalStatus.Pending)
            {
                throw new Exception("Chỉ có yêu cầu ở trạng thái 'Pending' mới được phép từ chối.");
            }

            status.Status = WithdrawalStatus.Rejected;
            withDrawalRepository.Update(status);
            await withDrawalRepository.SaveChangeASync();

            return Unit.Value;
        }
    }
}
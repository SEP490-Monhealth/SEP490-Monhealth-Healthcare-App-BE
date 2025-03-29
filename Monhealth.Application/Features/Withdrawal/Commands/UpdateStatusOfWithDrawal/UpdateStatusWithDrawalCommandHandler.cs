using MediatR;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class UpdateStatusWithdrawalCommandHandler(IWithdrawalRepository withDrawalRepository) : IRequestHandler<UpdateStatusWithdrawalCommand, Unit>
    {
        public async Task<Unit> Handle(UpdateStatusWithdrawalCommand request, CancellationToken cancellationToken)
        {
            var withDrawalRequest = await withDrawalRepository.GetByIdAsync(request.WithdrawalRequestId);
            switch (withDrawalRequest.Status) // Assuming 'Status' is the property to check
            {
                case WithdrawalStatus.Pending:
                    withDrawalRequest.Status = WithdrawalStatus.Approved;
                    break;
                case WithdrawalStatus.Approved:
                    withDrawalRequest.Status = WithdrawalStatus.Completed;
                    break;
                case WithdrawalStatus.Completed:
                    throw new Exception("Yêu cầu đã hoàn tất, không thể xử lý thêm.");
                default:
                    throw new Exception("Trạng thái yêu cầu không hợp lệ");
            }
            withDrawalRepository.Update(withDrawalRequest);
            await withDrawalRepository.SaveChangeASync();
            return Unit.Value;
        }
    }
}
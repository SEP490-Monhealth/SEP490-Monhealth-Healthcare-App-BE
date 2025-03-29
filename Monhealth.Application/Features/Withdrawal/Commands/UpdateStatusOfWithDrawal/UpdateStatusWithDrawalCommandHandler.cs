using MediatR;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class UpdateStatusWithdrawalCommandHandler(IWithdrawalRepository withdrawalRepository) : IRequestHandler<UpdateStatusWithdrawalCommand, Unit>
    {
        public async Task<Unit> Handle(UpdateStatusWithdrawalCommand request, CancellationToken cancellationToken)
        {
            var withdrawalRequest = await withdrawalRepository.GetByIdAsync(request.WithdrawalRequestId);
            switch (withdrawalRequest.Status) // Assuming 'Status' is the property to check
            {
                case WithdrawalStatus.Pending:
                    withdrawalRequest.Status = WithdrawalStatus.Approved;
                    break;
                case WithdrawalStatus.Approved:
                    withdrawalRequest.Status = WithdrawalStatus.Completed;
                    break;
                case WithdrawalStatus.Completed:
                    throw new Exception("Yêu cầu đã hoàn tất, không thể xử lý thêm.");
                default:
                    throw new Exception("Trạng thái yêu cầu không hợp lệ");
            }
            withdrawalRepository.Update(withdrawalRequest);
            await withdrawalRepository.SaveChangeASync();
            return Unit.Value;
        }
    }
}
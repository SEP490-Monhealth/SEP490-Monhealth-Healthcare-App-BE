using MediatR;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class UpdateStatusWithDrawalCommandHandler(IWithdrawalRepository withDrawalRepository) : IRequestHandler<UpdateStatusWithDrawalCommand, Unit>
    {
        public async Task<Unit> Handle(UpdateStatusWithDrawalCommand request, CancellationToken cancellationToken)
        {
            var withDrawalRequest = await withDrawalRepository.GetByIdAsync(request.WithDrawalRequestId);
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
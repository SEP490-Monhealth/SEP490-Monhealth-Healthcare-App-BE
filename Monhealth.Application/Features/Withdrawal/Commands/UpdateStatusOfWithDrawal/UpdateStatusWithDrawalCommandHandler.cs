using MediatR;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class UpdateStatusWithDrawalCommandHandler(IWithDrawalRepository withDrawalRepository) : IRequestHandler<UpdateStatusWithDrawalCommand, Unit>
    {
        public async Task<Unit> Handle(UpdateStatusWithDrawalCommand request, CancellationToken cancellationToken)
        {
            var withDrawalRequest = await withDrawalRepository.GetByIdAsync(request.WithDrawalRequestId);
            switch (withDrawalRequest.Status) // Assuming 'Status' is the property to check
            {
                case WithDrawalStatus.Pending:
                    withDrawalRequest.Status = WithDrawalStatus.Approved;
                    break;
                case WithDrawalStatus.Approved:
                    withDrawalRequest.Status = WithDrawalStatus.Completed;
                    break;
                case WithDrawalStatus.Completed:
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
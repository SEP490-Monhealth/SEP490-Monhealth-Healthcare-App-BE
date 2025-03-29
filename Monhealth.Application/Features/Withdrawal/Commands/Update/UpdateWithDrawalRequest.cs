using MediatR;

namespace Monhealth.Application
{
    public class UpdateWithdrawalRequest : IRequest<bool>
    {
        public Guid WithdrawalRequestId { get; set; }
        public UpdateWithdrawalDTO Request { get; set; }
        public UpdateWithdrawalRequest(UpdateWithdrawalDTO request, Guid withDrawRequestId)
        {
            WithdrawalRequestId = withDrawRequestId;
            Request = request;
        }
    }
}
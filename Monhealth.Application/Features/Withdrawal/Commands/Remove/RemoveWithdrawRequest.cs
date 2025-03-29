using MediatR;

namespace Monhealth.Application
{
    public class RemoveWithdrawRequest : IRequest<bool>
    {
        public Guid WithdrawalRequestId { get; set; }
        public RemoveWithdrawRequest(Guid id)
        {
            WithdrawalRequestId = id;
        }

    }
}
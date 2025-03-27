using MediatR;

namespace Monhealth.Application
{
    public class RemoveWithdrawRequest : IRequest<bool>
    {
        public Guid WithDrawalRequestId { get; set; }
        public RemoveWithdrawRequest(Guid id)
        {
            WithDrawalRequestId = id;
        }

    }
}
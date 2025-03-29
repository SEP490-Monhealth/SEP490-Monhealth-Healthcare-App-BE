using MediatR;

namespace Monhealth.Application
{
    public class CancelWithDrawalStatusCommand : IRequest<Unit>
    {
        public Guid WithDrawalRequestId { get; set; }
        public CancelWithDrawalStatusCommand(Guid id)
        {
            WithDrawalRequestId = id;
        }


    }
}
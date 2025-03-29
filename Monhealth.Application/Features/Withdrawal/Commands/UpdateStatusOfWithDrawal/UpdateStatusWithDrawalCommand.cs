using MediatR;

namespace Monhealth.Application
{
    public class UpdateStatusWithDrawalCommand : IRequest<Unit>
    {
        public Guid WithDrawalRequestId { get; set; }
        public UpdateStatusWithDrawalCommand(Guid id)
        {
            WithDrawalRequestId = id;
        }

    }
}
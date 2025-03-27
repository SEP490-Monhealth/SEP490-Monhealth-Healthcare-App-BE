using MediatR;

namespace Monhealth.Application
{
    public class UpdateWithDrawalRequest : IRequest<bool>
    {
        public Guid WithDrawalRequestId { get; set; }
        public UpdateWithDrawalDTO Request { get; set; }
        public UpdateWithDrawalRequest(UpdateWithDrawalDTO request, Guid withDrawRequestId)
        {
            WithDrawalRequestId = withDrawRequestId;
            Request = request;
        }

    }
}
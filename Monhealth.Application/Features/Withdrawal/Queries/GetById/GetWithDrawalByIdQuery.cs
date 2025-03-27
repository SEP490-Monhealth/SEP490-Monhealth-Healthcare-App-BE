using MediatR;

namespace Monhealth.Application
{
    public class GetWithDrawalByIdQuery : IRequest<GetWithDrawalByIdDTO>
    {
        public Guid WithDrawalRequestId { get; set; }
    }
}
using MediatR;

namespace Monhealth.Application
{
    public class GetWithdrawalByIdQuery : IRequest<GetWithdrawalByIdDTO>
    {
        public Guid WithdrawalRequestId { get; set; }
    }
}
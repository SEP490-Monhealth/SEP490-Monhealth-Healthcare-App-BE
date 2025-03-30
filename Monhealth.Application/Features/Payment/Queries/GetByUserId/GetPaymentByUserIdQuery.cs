using MediatR;

namespace Monhealth.Application.Features.Payment.Queries.GetByUserId
{
    public class GetPaymentByUserIdQuery : IRequest<List<GetPaymentByUserIdDTO>>
    {
        public Guid UserId { get; set; }
    }
}

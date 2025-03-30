using MediatR;

namespace Monhealth.Application.Features.Payment.Queries.GetBySubcriptionId
{
    public class GetpaymentBySubcriptionIdQuery : IRequest<List<GetPaymentBySubscriptionIdDTO>>
    {
        public Guid SubscriptionId { get; set; }
    }
}

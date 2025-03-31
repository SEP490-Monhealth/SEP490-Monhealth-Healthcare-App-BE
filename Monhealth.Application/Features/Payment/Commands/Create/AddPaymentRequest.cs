using MediatR;

namespace Monhealth.Application.Features.Payment.Commands.Create
{
    public class AddPaymentRequest : IRequest<AddPaymentResponse>
    {
        public Guid UserId { get; set; }
        public Guid UserSubscriptionId { get; set; }
        public int Amount { get; set; }
    }
}
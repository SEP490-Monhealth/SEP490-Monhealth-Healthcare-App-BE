using MediatR;

namespace Monhealth.Application.Features.Payment.Commands.Create
{
    public class AddPaymentRequest : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public Guid SubscriptionId { get; set; } 
        public int Amount { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
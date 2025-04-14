using MediatR;

namespace Monhealth.Application.Features.Transaction.Commands.CreateUpgradeSubscriptionPayment
{
    public class CreateUpgradeRequest : IRequest<CreateUpgradeResponse>
    {
        public Guid UserId { get; set; }
        public Guid SubscriptionId { get; set; }
        public string? Description { get; set; }
        public int Amount { get; set; }
    }
}

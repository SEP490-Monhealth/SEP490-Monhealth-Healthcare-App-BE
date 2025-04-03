using MediatR;

namespace Monhealth.Application.Features.UserSubscription.Commands.Create;

public class CreateUserSubscriptionCommand : IRequest<Unit>
{
    public Guid UserId { get; set; }
    public Guid SubscriptionId { get; set; }
    public Guid PaymentId { get; set; }
}
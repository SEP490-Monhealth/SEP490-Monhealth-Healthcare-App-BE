using MediatR;
using Monhealth.Core.Enum;

namespace Monhealth.Application.Features.UserSubscription.Commands.Create;

public class CreateUserSubscriptionCommand : IRequest<Unit>
{
    public Guid UserId { get; set; }
    public Guid SubscriptionId { get; set; }
    public int Duration { get; set; }
    public string StartAt { get; set; } = null!;
    public Status Status { get; set; }

}
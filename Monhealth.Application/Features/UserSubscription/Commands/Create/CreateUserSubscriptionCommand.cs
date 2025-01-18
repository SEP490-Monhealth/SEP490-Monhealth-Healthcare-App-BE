using MediatR;

namespace Monhealth.Application.Features.UserSubscription.Commands.Create;

public record CreateUserSubscriptionCommand(CreateUserSubscriptionDTO Request) : IRequest;
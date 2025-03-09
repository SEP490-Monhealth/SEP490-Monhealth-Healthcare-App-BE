using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserSubscription.Commands.Create
{
    public class CreateUserSubscriptionCommandHandler : IRequestHandler<CreateUserSubscriptionCommand, Unit>
    {
        private readonly IUserSubscriptionRepository _userSubscriptionRepository;

        public CreateUserSubscriptionCommandHandler(IUserSubscriptionRepository userSubscriptionRepository)
        {
            _userSubscriptionRepository = userSubscriptionRepository;
        }

        public async Task<Unit> Handle(CreateUserSubscriptionCommand request, CancellationToken cancellationToken)
        {
            var model = new Domain.UserSubscription
            {
                SubscriptionId = request.SubscriptionId,
                UserId = request.UserId,
                StartedAt = request.StartedAt,
                Status = Core.Enum.UserSubscriptionStatus.Active,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };
            _userSubscriptionRepository.Add(model);
            await _userSubscriptionRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}
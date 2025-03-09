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
            int Duration = request.Duration;
            var model = new Monhealth.Domain.UserSubscription
            {
                CreatedAt = DateTime.Now,
                ExpiresAt = DateTime.Now.AddDays(Duration),
                SubscriptionId = request.SubscriptionId,
                UserId = request.UserId,
                Status = request.Status,
                StartAt = request.StartAt,
                UpdatedAt = DateTime.Now,
            };

            _userSubscriptionRepository.Add(model);
            await _userSubscriptionRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}
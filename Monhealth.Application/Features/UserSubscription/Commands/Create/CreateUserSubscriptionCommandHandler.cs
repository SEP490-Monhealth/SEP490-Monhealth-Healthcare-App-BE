using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserSubscription.Commands.Create
{
    public class CreateUserSubscriptionCommandHandler : IRequestHandler<CreateUserSubscriptionCommand>
    {
        private readonly IUserSubscriptionRepository _userSubscriptionRepository;

        public CreateUserSubscriptionCommandHandler(IUserSubscriptionRepository userSubscriptionRepository)
        {
            _userSubscriptionRepository = userSubscriptionRepository;
        }

        public async Task<Unit> Handle(CreateUserSubscriptionCommand request, CancellationToken cancellationToken)
        {
            int Duration = request.Request.Duration;
            var model = new Monhealth.Domain.UserSubscription
            {
                CreatedAt = DateTime.Now,
                ExpiresAt = DateTime.Now.AddDays(Duration),
                SubscriptionId = request.Request.SubscriptionId,
                UserId = request.Request.UserId,
                UpdatedAt = DateTime.Now,
            };

            _userSubscriptionRepository.Add(model);
            await _userSubscriptionRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}
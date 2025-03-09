using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Subscription.Commands.Create
{
    public class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, Unit>
    {
        private readonly ISubscriptionRepository _subscriptionRepository;
        public CreateSubscriptionCommandHandler(ISubscriptionRepository subscriptionRepository)
        {
            _subscriptionRepository = subscriptionRepository;
        }

        public async Task<Unit> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
        {
            var model = new Monhealth.Domain.Subscription
            {
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                SubscriptionName = request.SubscriptionName,
                Price = request.Price,
                DurationDays = request.DurationDays,
                SubscriptionDescription = request.SubscriptionDescription,
                Features = request.Features,
                Status = true
            };
            _subscriptionRepository.Add(model);
            await _subscriptionRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}
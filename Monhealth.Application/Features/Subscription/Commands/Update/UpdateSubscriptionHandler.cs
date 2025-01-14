using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Subscription.Commands.Update
{
    public class UpdateSubscriptionHandler : IRequestHandler<UpdateSubscriptionCommand, bool>
    {
        private readonly ISubscriptionRepository _subscriptionRepository;

        public UpdateSubscriptionHandler(ISubscriptionRepository subscriptionRepository)
        {
            _subscriptionRepository = subscriptionRepository;
        }

        public async Task<bool> Handle(UpdateSubscriptionCommand request, CancellationToken cancellationToken)
        {
            var id =await _subscriptionRepository.GetByIdAsync(request.SubscriptionId);
            id.SubscriptionName = request.Request.SubscriptionName;
            id.Price = request.Request.Price;
            _subscriptionRepository.Update(id);
            await _subscriptionRepository.SaveChangeAsync();
            return true;
        }
    }
}
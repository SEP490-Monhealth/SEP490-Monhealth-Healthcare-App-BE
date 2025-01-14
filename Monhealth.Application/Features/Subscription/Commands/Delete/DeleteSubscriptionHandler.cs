using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Subscription.Commands.Delete
{
    public class DeleteSubscriptionHandler : IRequestHandler<DeleteSubscriptionRequest, bool>
    {
        private readonly ISubscriptionRepository _subscriptionRepository;
        public DeleteSubscriptionHandler(ISubscriptionRepository subscriptionRepository)
        {
            _subscriptionRepository = subscriptionRepository;
        }

        public async Task<bool> Handle(DeleteSubscriptionRequest request, CancellationToken cancellationToken)
        {
            var id = await _subscriptionRepository.GetByIdAsync(request.SubscriptionId);
            _subscriptionRepository.Remove(id);
            await _subscriptionRepository.SaveChangeAsync();
            return true;
        }
    }
}
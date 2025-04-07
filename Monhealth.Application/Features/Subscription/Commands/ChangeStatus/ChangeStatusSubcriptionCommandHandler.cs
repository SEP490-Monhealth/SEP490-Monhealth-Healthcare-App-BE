using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Subscription.Commands.ChangeStatus
{
    public class ChangeStatusSubcriptionCommandHandler(ISubscriptionRepository subscriptionRepository) : IRequestHandler<ChangeStatusSubscriptionCommand, bool>
    {
        public async Task<bool> Handle(ChangeStatusSubscriptionCommand request, CancellationToken cancellationToken)
        {
            var subscription = await subscriptionRepository.GetByIdAsync(request.SubscriptionId);
            if (subscription == null)
            {
                return false;
            }
            subscription.Status = !subscription.Status;
            subscriptionRepository.Update(subscription);
            await subscriptionRepository.SaveChangeAsync();
            return true;
        }
    }
}

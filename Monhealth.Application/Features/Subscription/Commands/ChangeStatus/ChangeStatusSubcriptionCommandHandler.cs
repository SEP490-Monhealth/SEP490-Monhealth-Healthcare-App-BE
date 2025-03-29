using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Subscription.Commands.ChangeStatus
{
    public class ChangeStatusSubcriptionCommandHandler(ISubscriptionRepository subscriptionRepository) : IRequestHandler<ChangeStatusSubcriptionCommand, bool>
    {
        public async Task<bool> Handle(ChangeStatusSubcriptionCommand request, CancellationToken cancellationToken)
        {
            var subcription = await subscriptionRepository.GetByIdAsync(request.SubcriptionId);
            if (subcription == null)
            {
                return false;
            }
            subcription.Status = !subcription.Status;
            subscriptionRepository.Update(subcription);
            await subscriptionRepository.SaveChangeAsync();
            return true;
        }
    }
}

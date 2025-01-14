using MediatR;

namespace Monhealth.Application.Features.Subscription.Commands.Update
{
    public class UpdateSubscriptionCommand : IRequest<bool>
    {
        public Guid SubscriptionId;
        public UpdateSubscriptionRequest Request { get; set; }
        public UpdateSubscriptionCommand(Guid subscriptionId, UpdateSubscriptionRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request), "Request cannot be null");
            }

            SubscriptionId = subscriptionId;
            Request = request;

            // Initialize properties as needed
            Request.SubscriptionName = request.SubscriptionName ?? string.Empty;
            Request.Price = request.Price;
        }
    }
}
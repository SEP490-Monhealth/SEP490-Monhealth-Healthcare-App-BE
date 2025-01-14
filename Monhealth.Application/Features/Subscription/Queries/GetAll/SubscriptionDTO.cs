namespace Monhealth.Application.Features.Subscription.Queries.GetAll
{
    public class SubscriptionDTO
    {
        public Guid SubscriptionId { get; set; }
        public string SubscriptionName { get; set; } = string.Empty;
        public int Price { get; set; }

    }
}
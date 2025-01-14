namespace Monhealth.Application.Features.Subscription.Queries.GetByUser
{
    public class SubscriptionByUserDTO
    {
        public Guid SubscriptionId { get; set; }
        public string SubscriptionName { get; set; } = string.Empty;
        public int Price { get; set; }
    }
}
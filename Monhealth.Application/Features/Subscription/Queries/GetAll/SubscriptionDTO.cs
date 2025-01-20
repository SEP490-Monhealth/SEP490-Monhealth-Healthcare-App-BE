using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Subscription.Queries.GetAll
{
    public class SubscriptionDTO : BaseEntity
    {
        public Guid SubscriptionId { get; set; }
        public string SubscriptionName { get; set; } = string.Empty;
        public int Price { get; set; }
    }
}
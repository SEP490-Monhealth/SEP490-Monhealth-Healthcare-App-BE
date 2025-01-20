using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Subscription.Queries.GetDetail
{
    public class SubscriptionDetailDTO : BaseEntity
    {
        public string SubscriptionName { get; set; } = string.Empty;
        public int Price { get; set; }
    }
}
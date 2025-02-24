using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Payment.Queries.GetById
{
    public class PaymentByIdDTO : BaseEntity
    {
        public Guid SubscriptionId { get; set; } 
        public int Amount { get; set; }
        public string Status { get; set; } = string.Empty;

    }
}
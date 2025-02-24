using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Payment.Queries.GetALL
{
    public class PaymentDTO : BaseEntity
    {
        public Guid PaymentId { get; set; } // PK
        public Guid SubscriptionId { get; set; } // FK
        public int Amount { get; set; }
        public string Status { get; set; } = string.Empty;
        
    }
}
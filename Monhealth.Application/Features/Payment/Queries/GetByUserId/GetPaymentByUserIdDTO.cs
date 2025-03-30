using Monhealth.Core;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Payment.Queries.GetByUserId
{
    public class GetPaymentByUserIdDTO : TimeEntity
    {
        public Guid PaymentId { get; set; }
        public Guid UserId { get; set; }
        public Guid SubscriptionId { get; set; }
        public int Amount { get; set; }
        public PaymentStatus Status { get; set; }
    }
}

using Monhealth.Core;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Payment.Queries.GetBySubcriptionId
{
    public class GetpaymentBySubcriptionIdDTO : TimeEntity
    {
        public Guid PaymentId { get; set; }
        public Guid UserId { get; set; }
        public Guid SubscriptionId { get; set; }
        public int Amount { get; set; }
        public PaymentStatus Status { get; set; }
    }
}

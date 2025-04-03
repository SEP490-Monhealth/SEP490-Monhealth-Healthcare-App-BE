using Monhealth.Core;

namespace Monhealth.Application.Features.Payment.Commands.Create
{
    public class AddPaymentResponse
    {
        public Guid PaymentId { get; set; }
        public Guid UserId { get; set; }
        public int Amount { get; set; }
        public PaymentStatus Status { get; set; }
        public string PaymentUrl { get; set; }
        public string QrCode { get; set; }
    }
}

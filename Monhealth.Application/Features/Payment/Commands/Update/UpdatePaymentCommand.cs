using MediatR;

namespace Monhealth.Application.Features.Payment.Commands.Update
{
    public class UpdatePaymentCommand : IRequest<bool>
    {
        public Guid PaymentId { get; set; }
        public int Amount { get; set; }
        public UpdatePaymentCommand(Guid paymentId, int amount)
        {
            PaymentId = paymentId;
            Amount = amount;
        }

    }
}
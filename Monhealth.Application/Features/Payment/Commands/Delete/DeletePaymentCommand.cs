using MediatR;

namespace Monhealth.Application.Features.Payment.Commands.Create
{
    public class DeletePaymentCommand : IRequest<bool>
    {
        public Guid PaymentId { get; set; }
        public DeletePaymentCommand(Guid paymentId)
        {
            PaymentId = paymentId;
        }

    }
}
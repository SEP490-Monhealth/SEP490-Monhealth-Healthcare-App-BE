using MediatR;

namespace Monhealth.Application.Features.Payment.Commands.Update
{
    public class UpdatePaymentCommand : IRequest<bool>
    {
        public Guid PaymentId { get; set; }
        public UpdatePaymentDto UpdatePaymentDto { get; set; }
        public UpdatePaymentCommand(Guid paymentId, UpdatePaymentDto updatePaymentDto)
        {
            PaymentId = paymentId;
            UpdatePaymentDto = updatePaymentDto;
        }

    }
}
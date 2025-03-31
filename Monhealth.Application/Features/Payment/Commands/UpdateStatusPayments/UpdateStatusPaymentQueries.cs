
using MediatR;

namespace Monhealth.Application.Features.Payment.Commands.UpdateStatusPayments
{
    public class UpdateStatusPaymentQueries : IRequest<bool>
    {
        public Guid PaymentId { get; set; }
    }
}











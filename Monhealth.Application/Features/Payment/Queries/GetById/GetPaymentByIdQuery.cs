using MediatR;

namespace Monhealth.Application.Features.Payment.Queries.GetById
{
    public class GetPaymentByIdQuery : IRequest<PaymentByIdDTO>
    {
        public Guid PaymentId { get; set; }
    }
}
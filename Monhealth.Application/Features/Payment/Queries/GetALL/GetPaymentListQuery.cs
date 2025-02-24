using MediatR;

namespace Monhealth.Application.Features.Payment.Queries.GetALL
{
    public class GetPaymentListQuery : IRequest<List<PaymentDTO>>
    {
        
    }
}
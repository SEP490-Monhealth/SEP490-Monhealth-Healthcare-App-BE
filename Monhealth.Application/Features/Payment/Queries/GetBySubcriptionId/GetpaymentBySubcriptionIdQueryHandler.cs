using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Payment.Queries.GetBySubcriptionId
{
    public class GetpaymentBySubcriptionIdQueryHandler(IPaymentRepository paymentRepository, IMapper mapper) : IRequestHandler<GetpaymentBySubcriptionIdQuery, List<GetPaymentBySubscriptionIdDTO>>
    {
        public async Task<List<GetPaymentBySubscriptionIdDTO>> Handle(GetpaymentBySubcriptionIdQuery request, CancellationToken cancellationToken)
        {
            var listPayments = await paymentRepository.GetPaymentBySubscriptionId(request.SubscriptionId);
            return mapper.Map<List<GetPaymentBySubscriptionIdDTO>>(listPayments);
        }
    }
}

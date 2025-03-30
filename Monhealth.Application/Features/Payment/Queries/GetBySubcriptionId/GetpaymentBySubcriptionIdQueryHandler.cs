using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Payment.Queries.GetBySubcriptionId
{
    public class GetpaymentBySubcriptionIdQueryHandler(IPaymentRepository paymentRepository, IMapper mapper) : IRequestHandler<GetpaymentBySubcriptionIdQuery, List<GetpaymentBySubcriptionIdDTO>>
    {
        public async Task<List<GetpaymentBySubcriptionIdDTO>> Handle(GetpaymentBySubcriptionIdQuery request, CancellationToken cancellationToken)
        {
            var listPayments = await paymentRepository.GetPaymentBySubcriptionId(request.SubcriptionId);
            return mapper.Map<List<GetpaymentBySubcriptionIdDTO>>(listPayments);
        }
    }
}

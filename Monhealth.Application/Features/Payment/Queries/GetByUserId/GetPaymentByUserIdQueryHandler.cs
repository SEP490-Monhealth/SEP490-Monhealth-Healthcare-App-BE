using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Payment.Queries.GetByUserId
{
    public class GetPaymentByUserIdQueryHandler(IPaymentRepository paymentRepository, IMapper mapper) : IRequestHandler<GetPaymentByUserIdQuery, List<GetPaymentByUserIdDTO>>
    {
        public async Task<List<GetPaymentByUserIdDTO>> Handle(GetPaymentByUserIdQuery request, CancellationToken cancellationToken)
        {
            var listPayment = await paymentRepository.GetPaymentByUserId(request.UserId);
            return mapper.Map<List<GetPaymentByUserIdDTO>>(listPayment);
        }
    }
}

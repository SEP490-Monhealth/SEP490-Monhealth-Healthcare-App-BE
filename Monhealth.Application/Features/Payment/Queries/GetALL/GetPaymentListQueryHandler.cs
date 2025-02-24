using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Payment.Queries.GetALL
{
    public class GetPaymentListQueryHandler : IRequestHandler<GetPaymentListQuery, List<PaymentDTO>>
    {
        private readonly IPaymentRepository _paymentRepository;
        public GetPaymentListQueryHandler(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<List<PaymentDTO>> Handle(GetPaymentListQuery request, CancellationToken cancellationToken)
        {
            var query = await _paymentRepository.GetAllAsync();
            return query.Select(p => new PaymentDTO
            {
                  Amount = p.Amount,
                  PaymentId = p.PaymentId,
                  Status = p.Status,
                  SubscriptionId = p.SubscriptionId,
                  CreatedAt = p.CreatedAt,
                  UpdatedAt = p.UpdatedAt
            }).ToList();
        }
    }
}
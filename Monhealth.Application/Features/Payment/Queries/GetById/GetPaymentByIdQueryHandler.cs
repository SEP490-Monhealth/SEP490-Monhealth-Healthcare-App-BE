using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Payment.Queries.GetById
{
    public class GetPaymentByIdQueryHandler : IRequestHandler<GetPaymentByIdQuery, PaymentByIdDTO>
    {
        private readonly IPaymentRepository _paymentRepository;
        public GetPaymentByIdQueryHandler(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<PaymentByIdDTO> Handle(GetPaymentByIdQuery request, CancellationToken cancellationToken)
        {
            var query = await _paymentRepository.GetByIdAsync(request.PaymentId);
            return new PaymentByIdDTO
            {
                Amount = query.Amount,
                CreatedAt = query.CreatedAt,
                UpdatedAt = query.UpdatedAt,
                Status = query.Status,
                SubscriptionId = query.SubscriptionId,
            };
        }
    }
}
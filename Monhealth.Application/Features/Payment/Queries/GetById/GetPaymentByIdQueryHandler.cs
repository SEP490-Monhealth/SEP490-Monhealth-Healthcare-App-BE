using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Payment.Queries.GetById
{
    public class GetPaymentByIdQueryHandler : IRequestHandler<GetPaymentByIdQuery, PaymentByIdDTO>
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IUserRepository _userRepository;
        public GetPaymentByIdQueryHandler(IPaymentRepository paymentRepository,
        IUserRepository userRepository)
        {
            _paymentRepository = paymentRepository;
            _userRepository = userRepository;
        }

        public async Task<PaymentByIdDTO> Handle(GetPaymentByIdQuery request, CancellationToken cancellationToken)
        {
            var query = await _paymentRepository.GetPaymentById(request.PaymentId);
            var member = await _userRepository.GetUserByIdAsync((Guid)query.CreatedBy);
            return new PaymentByIdDTO
            {
                Amount = query.Amount,
                CreatedAt = query.CreatedAt,
                UpdatedAt = query.UpdatedAt,
                CreatedBy = query.CreatedBy,
                UpdatedBy = query.UpdatedBy,
                Status = query.Status,

                SubscriptionId = query.UserSubscription?.SubscriptionId ?? Guid.Empty, // fallback nếu null
                PaymentId = query.PaymentId,
                SubscriptionName = query.UserSubscription?.Subscription?.SubscriptionName ?? string.Empty,

                Member = new Member
                {
                    AvatarUrl = member?.Avatar ?? string.Empty,
                    FullName = member?.FullName ?? string.Empty,
                    Email = member?.Email ?? string.Empty,
                    PhoneNumber = member?.PhoneNumber ?? string.Empty,
                }
            };
        }
    }
}
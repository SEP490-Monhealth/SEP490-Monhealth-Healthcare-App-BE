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
            var member = await _userRepository.GetUserByIdAsync(query.UserSubscription.UserId);
            return new PaymentByIdDTO
            {
                Amount = query.Amount,
                CreatedAt = query.CreatedAt,
                UpdatedAt = query.UpdatedAt,
                Status = query.Status,
                //SubscriptionId = query.UserSubcriptionId,
                PaymentId = query.PaymentId,
                //SubscriptionName = query.Subscription?.SubscriptionName,
                Member = new Member
                {
                    AvatarUrl = member.Avatar,
                    FullName = member.FullName,
                    Email = member.Email,
                    PhoneNumber = member.PhoneNumber,

                }
            };
        }
    }
}
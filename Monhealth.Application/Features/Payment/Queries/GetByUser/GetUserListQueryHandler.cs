using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
    public class GetUserListQueryHandler(IPaymentRepository paymentRepository
    , IUserRepository userRepository) : IRequestHandler<GetUserListQuery, List<PaymentUserDTO>>
    {
        public async Task<List<PaymentUserDTO>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            var queries = await paymentRepository.GetPaymentByUser(request.UserId);
            var member = await userRepository.GetUserByIdAsync(request.UserId);

            if (member == null)
            {
                throw new Exception($"User with ID {request.UserId} not found.");
            }

            var paymentList = new List<PaymentUserDTO>();

            foreach (var payment in queries)
            {
                if (payment.Subscription == null)
                {
                    throw new Exception($"Payment {payment.PaymentId} is missing Subscription.");
                }

                var memberDTO = new Member
                {
                    AvatarUrl = member.Avatar,
                    Email = member.Email,
                    FullName = member.FullName,
                    PhoneNumber = member.PhoneNumber,
                };

                var paymentDTO = new PaymentUserDTO(
                    payment.PaymentId,
                    payment.UserId,
                    payment.SubscriptionId,
                    payment.Subscription.SubscriptionName,
                    memberDTO,
                    payment.Amount,
                    payment.Status,
                    payment.CreatedAt,
                    payment.UpdatedAt,
                    payment.CreatedBy,
                    payment.UpdatedBy
                );

                paymentList.Add(paymentDTO);
            }

            return paymentList;
        }

    }

}
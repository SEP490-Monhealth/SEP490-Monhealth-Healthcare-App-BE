using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Review.Queries;
using Monhealth.Application.Models;

namespace Monhealth.Application
{
    public class GetUserListQueryHandler(IPaymentRepository paymentRepository
    , IUserRepository userRepository) : IRequestHandler<GetUserListQuery, PageResult<PaymentUserDTO>>
    {
        public async Task<PageResult<PaymentUserDTO>> Handle(GetUserListQuery request, CancellationToken cancellationToken)
        {
            var queries = await paymentRepository.GetPaymentByUser(request.UserId, request.Page, request.Limit);
            var member = await userRepository.GetUserByIdAsync(request.UserId);

            if (member == null)
            {
                throw new Exception($"User with ID {request.UserId} not found.");
            }

            var paymentList = new List<PaymentUserDTO>();

            foreach (var payment in queries.Items)
            {
                if (payment.UserSubscription == null)
                {
                    throw new Exception($"Thanh toán {payment.PaymentId} không tìm thấy.");
                }

                var memberDTO = new Member
                {
                    AvatarUrl = member.Avatar ?? string.Empty,
                    Email = member.Email ?? string.Empty,
                    FullName = member.FullName ?? string.Empty,
                    PhoneNumber = member.PhoneNumber ?? string.Empty,
                };

                var paymentDTO = new PaymentUserDTO(
                    payment.PaymentId,
                    payment.UserSubscription.UserId,
                    payment.UserSubscription.SubscriptionId,
                    memberDTO,
                    payment.UserSubscription.Subscription.SubscriptionName,
                    payment.Description,
                    payment.Amount,
                    payment.Status,
                    payment.CreatedAt,
                    payment.UpdatedAt,
                    payment.CreatedBy,
                    payment.UpdatedBy
                );

                paymentList.Add(paymentDTO);
            }

            return new PageResult<PaymentUserDTO>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(queries.TotalCount / (double)request.Limit),
                TotalItems = queries.TotalCount,
                Items = paymentList
            };
        }
    }
}
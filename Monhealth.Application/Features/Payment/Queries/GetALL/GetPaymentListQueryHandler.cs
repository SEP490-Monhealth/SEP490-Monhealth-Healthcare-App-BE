using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Payment.Queries.GetALL
{
    public class GetPaymentListQueryHandler : IRequestHandler<GetPaymentListQuery, PageResult<PaymentDTO>>
    {
        private readonly IPaymentRepository _paymentRepository;
        private readonly IUserRepository _userRepository;
        public GetPaymentListQueryHandler(IPaymentRepository paymentRepository,
        IUserRepository userRepository)
        {
            _paymentRepository = paymentRepository;
            _userRepository = userRepository;
        }

        public async Task<PageResult<PaymentDTO>> Handle(GetPaymentListQuery request, CancellationToken cancellationToken)
        {
            var query = await _paymentRepository
                .GetAllPaymentsWithPagination(request.page, request.limit, request.search, request.status);

            var paymentList = new List<PaymentDTO>();

            foreach (var payment in query.Items)
            {
                var paymentDTO = new PaymentDTO
                {
                    Amount = payment.Amount,
                    CreatedAt = payment.CreatedAt,
                    PaymentId = payment.PaymentId,
                    Status = payment.Status,
                    SubscriptionId = payment.UserSubscription.SubscriptionId,
                    SubscriptionName = payment.UserSubscription?.Subscription?.SubscriptionName, // xử lý null
                    UpdatedAt = payment.UpdatedAt
                };

                var member = await _userRepository.GetByIdAsync(payment.UserSubscription.UserId);
                if (member != null)
                {
                    paymentDTO.Member = new Member
                    {
                        AvatarUrl = member.Avatar,
                        Email = member.Email,
                        FullName = member.FullName,
                        PhoneNumber = member.PhoneNumber,
                    };
                }

                paymentList.Add(paymentDTO);
            }

            return new PageResult<PaymentDTO>
            {
                CurrentPage = request.page,
                TotalPages = (int)Math.Ceiling(query.TotalCount / (double)request.limit),
                TotalItems = query.TotalCount,
                Items = paymentList
            };
        }

    }
}
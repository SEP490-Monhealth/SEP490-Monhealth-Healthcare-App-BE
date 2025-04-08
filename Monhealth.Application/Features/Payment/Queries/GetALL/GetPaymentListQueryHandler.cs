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
                    PaymentId = payment.PaymentId,
                    SubscriptionId = (payment.UserSubscription?.SubscriptionId) ?? Guid.Empty,
                    SubscriptionName = payment.UserSubscription?.Subscription?.SubscriptionName ?? string.Empty, // xử lý null
                    Description = payment.Description,
                    Amount = payment.Amount,
                    Status = payment.Status,
                    CreatedAt = payment.CreatedAt,
                    UpdatedAt = payment.UpdatedAt,
                    CreatedBy = payment.CreatedBy,
                    UpdatedBy = payment.UpdatedBy,
                };

                var member = await _userRepository.GetUserByIdAsync((Guid)payment.CreatedBy);
                if (member != null)
                {
                    paymentDTO.Member = new Member
                    {
                        AvatarUrl = member.Avatar ?? string.Empty,
                        Email = member.Email ?? string.Empty,
                        FullName = member.FullName ?? string.Empty,
                        PhoneNumber = member.PhoneNumber ?? string.Empty,
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
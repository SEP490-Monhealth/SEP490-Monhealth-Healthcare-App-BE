using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Payment.Queries.GetALL
{
    public class GetPaymentListQueryHandler : IRequestHandler<GetPaymentListQuery, PageResult<PaymentDTO>>
    {
        private readonly IPaymentRepository _paymentRepository;
        public GetPaymentListQueryHandler(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<PageResult<PaymentDTO>> Handle(GetPaymentListQuery request, CancellationToken cancellationToken)
        {
            var query = await _paymentRepository.GetAllPaymentsWithPagination(request.page, request.limit, request.search);
            var paymentList = query.Items.Select(p => new PaymentDTO
            {
                  Amount = p.Amount,
                  PaymentId = p.PaymentId,
                  Status = p.Status,
                  SubscriptionId = p.SubscriptionId,
                  CreatedAt = p.CreatedAt,
                  UpdatedAt = p.UpdatedAt
            }).ToList();

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
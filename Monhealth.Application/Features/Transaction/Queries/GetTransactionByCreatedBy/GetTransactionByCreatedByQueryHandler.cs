using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Transaction.Queries.GetTransactionByCreatedBy
{
    public class GetTransactionByCreatedByQueryHandler(ITransactionRepository transactionRepository,
        IMapper mapper) : IRequestHandler<GetTransactionByCreatedByQuery, PageResult<GetTransactionByCreatedByDTO>>
    {
        public async Task<PageResult<GetTransactionByCreatedByDTO>> Handle(GetTransactionByCreatedByQuery request, CancellationToken cancellationToken)
        {
            var listTransactions = await transactionRepository.GetTransactionByCreatedBy(request.UserId, request.Page, request.Limit);
            return new PageResult<GetTransactionByCreatedByDTO>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(listTransactions.TotalCount / (double)request.Limit),
                TotalItems = listTransactions.TotalCount,
                Items = mapper.Map<List<GetTransactionByCreatedByDTO>>(listTransactions.Items)
            };
        }
    }
}

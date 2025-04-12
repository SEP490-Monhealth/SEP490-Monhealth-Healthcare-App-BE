using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Transaction.Queries.GetTransactionByCreatedBy
{
    public class GetTransactionByCreatedByQueryHandler(ITransactionRepository transactionRepository, IMapper mapper) : IRequestHandler<GetTransactionByCreatedByQuery, List<GetTransactionByCreatedByDTO>>
    {
        public async Task<List<GetTransactionByCreatedByDTO>> Handle(GetTransactionByCreatedByQuery request, CancellationToken cancellationToken)
        {
            var listTransactions = await transactionRepository.GetTransactionByCreatedBy(request.UserId);
            return mapper.Map<List<GetTransactionByCreatedByDTO>>(listTransactions);
        }
    }
}

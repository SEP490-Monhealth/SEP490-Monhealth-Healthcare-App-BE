using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Features.Exercise.Queries.GetAllExercises;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Transaction.Queries.GetAllTransactions
{
    public class GetAllTransactionsQueryHandler : IRequestHandler<GetAllTransactionsQuery, PageResult<GetAllTransactionsDTO>>
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IMapper _mapper;
        public GetAllTransactionsQueryHandler(ITransactionRepository transactionRepository, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }
        public async Task<PageResult<GetAllTransactionsDTO>> Handle(GetAllTransactionsQuery request, CancellationToken cancellationToken)
        {
            var listTransactions = await _transactionRepository.GetAllTransactionsAsync(request.Page, request.Limit);
            var listTransactionsDto = _mapper.Map<List<GetAllTransactionsDTO>>(listTransactions.Items);
            return new PageResult<GetAllTransactionsDTO>()
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(listTransactions.TotalCount / (double)request.Limit),
                TotalItems = listTransactions.TotalCount,
                Items = listTransactionsDto
            };
        }
    }
}

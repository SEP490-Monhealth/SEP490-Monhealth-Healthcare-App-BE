using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Transaction.Queries.GetTransactionById
{
    public class GetTransactionByIdQueryHandler : IRequestHandler<GetTransactionByIdQuery, GetTransactionByIdDTO>
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IMapper _mapper;
        public GetTransactionByIdQueryHandler(ITransactionRepository transactionRepository, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }
        public async Task<GetTransactionByIdDTO> Handle(GetTransactionByIdQuery request, CancellationToken cancellationToken)
        {
            var transaction = await _transactionRepository.GetTransactionById(request.TransactionId);
            if (transaction == null)
            {
                throw new Exception("Không tìm thấy giao dịch");
            }
            return _mapper.Map<GetTransactionByIdDTO>(transaction);
        }
    }
}

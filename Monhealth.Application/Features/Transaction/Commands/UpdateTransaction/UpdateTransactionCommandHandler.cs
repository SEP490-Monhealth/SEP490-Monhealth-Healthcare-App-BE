using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Transaction.Commands.UpdateTransaction
{
    public class UpdateTransactionCommandHandler : IRequestHandler<UpdateTransactionCommand, bool>
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IMapper _mapper;
        public UpdateTransactionCommandHandler(ITransactionRepository transactionRepository, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }
        public async Task<bool> Handle(UpdateTransactionCommand request, CancellationToken cancellationToken)
        {
            var transaction = await _transactionRepository.GetByIdAsync(request.TransactionId);
            if (transaction == null)
            {
                throw new Exception("Không tìm thấy giao dịch");
            }
            var updateTransaction = _mapper.Map(request.UpdateTransactionDTO, transaction);
            updateTransaction.UpdatedAt = DateTime.Now;
            _transactionRepository.Update(updateTransaction);
            await _transactionRepository.SaveChangeAsync();
            return true;
        }
    }
}

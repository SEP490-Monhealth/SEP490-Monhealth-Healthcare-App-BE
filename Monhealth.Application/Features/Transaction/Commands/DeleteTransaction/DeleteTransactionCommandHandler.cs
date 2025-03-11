using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Transaction.Commands.DeleteTransaction
{
    public class DeleteTransactionCommandHandler : IRequestHandler<DeleteTransactionCommand, bool>
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IMapper _mapper;
        public DeleteTransactionCommandHandler(ITransactionRepository transactionRepository, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }
        public async Task<bool> Handle(DeleteTransactionCommand request, CancellationToken cancellationToken)
        {
            var existingTransaction = await _transactionRepository.GetByIdAsync(request.TransactionId);
            if (existingTransaction == null)
            {
                throw new Exception("Không tìm thấy giao dịch");
            }
            _transactionRepository.Remove(existingTransaction);
            await _transactionRepository.SaveChangeAsync();
            return true;
        }
    }
}

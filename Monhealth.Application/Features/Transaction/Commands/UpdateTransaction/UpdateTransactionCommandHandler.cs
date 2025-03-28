using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Transaction.Commands.UpdateTransaction
{
    public class UpdateTransactionCommandHandler : IRequestHandler<UpdateTransactionCommand, bool>
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IConsultantRepository _consultantRepository;
        private readonly IWalletRepository _walletRepository;
        private readonly IMapper _mapper;
        public UpdateTransactionCommandHandler(ITransactionRepository transactionRepository
        , IMapper mapper, IConsultantRepository consultantRepository,
        IWalletRepository walletRepository)
        {
            _transactionRepository = transactionRepository;
            _mapper = mapper;
            _consultantRepository = consultantRepository;
            _walletRepository = walletRepository;
        }
        public async Task<bool> Handle(UpdateTransactionCommand request, CancellationToken cancellationToken)
        {
            var consultant = await
            _consultantRepository.GetConsultantWithWalletAndTransactionsAsync(request.UpdateTransactionDTO.ConsultantId);

            var transaction = consultant.Wallet.Transactions
                 ?.FirstOrDefault(t => t.TransactionId 
                 == request.TransactionId);

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

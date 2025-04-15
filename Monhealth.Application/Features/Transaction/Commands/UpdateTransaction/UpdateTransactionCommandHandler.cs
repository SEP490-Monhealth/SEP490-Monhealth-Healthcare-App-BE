using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain.Enum;

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
            var transaction = await _transactionRepository.GetTransactionById(request.TransactionId);
            if (transaction == null) throw new BadRequestException("Không tìm thấy giao dich");

            var wallet = await _walletRepository.GetWalletByConsultantId((Guid)transaction.UserId);
            if (wallet is null) throw new BadRequestException("Không tìm thấy ví của tư vấn viên");

            if (wallet.Balance != null && wallet.Balance > 0)
            {
                if (transaction.TransactionType == TransactionType.Earning)
                {
                    wallet.Balance += transaction.Amount;
                }
                else if (transaction.TransactionType == TransactionType.Fee)
                {
                    if (wallet.Balance < transaction.Amount)
                    {
                        throw new BadRequestException("Không đủ số dư trong ví để thực hiện giao dịch phí.");
                    }
                    wallet.Balance -= transaction.Amount;
                }
                else if (transaction.TransactionType == TransactionType.Bonus)
                {
                    wallet.Balance += transaction.Amount;
                }
            }
            else
            {
                throw new BadRequestException("Không đủ số dư trong ví để thực hiện giao dịch");
            }
            transaction.Status = StatusTransaction.Completed;
            transaction.UpdatedAt = DateTime.Now;
            _transactionRepository.Update(transaction);
            await _transactionRepository.SaveChangeAsync();
            return true;

        }
    }
}

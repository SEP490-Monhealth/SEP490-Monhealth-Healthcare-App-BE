using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Transaction.Commands.UpdateTransaction
{
    public class UpdateTransactionCommandHandler : IRequestHandler<UpdateTransactionStatusQuery, bool>
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IConsultantRepository _consultantRepository;
        private readonly IWalletRepository _walletRepository;
        private readonly IMapper _mapper;

        public UpdateTransactionCommandHandler(
            ITransactionRepository transactionRepository,
            IMapper mapper,
            IConsultantRepository consultantRepository,
            IWalletRepository walletRepository)
        {
            _transactionRepository = transactionRepository;
            _mapper = mapper;
            _consultantRepository = consultantRepository;
            _walletRepository = walletRepository;
        }

        public async Task<bool> Handle(UpdateTransactionStatusQuery request, CancellationToken cancellationToken)
        {
            var transaction = await _transactionRepository.GetTransactionById(request.TransactionId)
                ?? throw new BadRequestException("Không tìm thấy giao dịch");

            var wallet = await _walletRepository.GetWalletByConsultantId((Guid)transaction.UserId)
                ?? throw new BadRequestException("Không tìm thấy ví của tư vấn viên");

            if (wallet.Balance is null || wallet.Balance < 0)
                throw new BadRequestException("Không đủ số dư trong ví để thực hiện giao dịch");

            switch (transaction.TransactionType)
            {
                case TransactionType.Earning:
                case TransactionType.Bonus:
                    wallet.Balance += transaction.Amount;
                    break;

                case TransactionType.Fee:
                case TransactionType.Withdrawal:
                    if (wallet.Balance < transaction.Amount)
                        throw new BadRequestException("Không đủ số dư trong ví để thực hiện giao dịch");
                    wallet.Balance -= transaction.Amount;
                    break;

                default:
                    throw new BadRequestException("Loại giao dịch không hợp lệ");
            }

            transaction.Status = StatusTransaction.Completed;
            transaction.UpdatedAt = DateTime.Now;

            _transactionRepository.Update(transaction);
            await _transactionRepository.SaveChangeAsync();

            return true;
        }
    }
}

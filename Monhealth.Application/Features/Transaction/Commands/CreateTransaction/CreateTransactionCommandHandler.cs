using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Transaction.Commands.CreateTransaction
{
    public class CreateTransactionCommandHandler : IRequestHandler<CreateTransactionCommand, Unit>
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly IBookingRepository _bookingRepository;
        private readonly IMapper _mapper;
        private readonly IWalletRepository _walletRepository;
        public CreateTransactionCommandHandler(ITransactionRepository transactionRepository,
            IBookingRepository bookingRepository, IMapper mapper, IWalletRepository walletRepository)
        {
            _transactionRepository = transactionRepository;
            _bookingRepository = bookingRepository;
            _mapper = mapper;
            _walletRepository = walletRepository;
        }
        public async Task<Unit> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
        {
            var wallet = await _walletRepository.GetByIdAsync(request.CreateTransactionDTO.WalletId);

            var checkBooking = await _bookingRepository.GetByIdAsync(request.CreateTransactionDTO.BookingId);
            if (checkBooking == null)
            {
                throw new Exception("Không tìm thấy booking");
            }
            var newTransaction = _mapper.Map<Domain.Transaction>(request.CreateTransactionDTO);
            newTransaction.TransactionId = Guid.NewGuid();
            newTransaction.Status = StatusTransaction.Pending;
            newTransaction.CreatedAt = DateTime.Now;
            newTransaction.UpdatedAt = DateTime.Now;
            if (wallet.Balance != null && wallet.Balance >= newTransaction.Amount)
            {
                if (newTransaction.TransactionType.Equals("Earning") && newTransaction.Status.Equals("Completed"))
                {
                    wallet.Balance += newTransaction.Amount;
                }
                else if (newTransaction.TransactionType.Equals("Withdrawal") && newTransaction.Status.Equals("Completed"))
                {
                    if (wallet.Balance < newTransaction.Amount)
                    {
                        throw new Exception("Không đủ số dư trong ví để thực hiện giao dịch rút tiền.");
                    }
                    wallet.Balance -= newTransaction.Amount;
                }
            }
            _transactionRepository.Add(newTransaction);
            await _transactionRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}

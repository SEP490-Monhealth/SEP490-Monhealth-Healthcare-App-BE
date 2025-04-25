using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
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
            var wallet = await _walletRepository.GetWalletByConsultantId(request.CreateTransactionDTO.ConsultantId);
            if (wallet == null) throw new BadRequestException("Không tìm thấy ví tư vấn viên");

            var newTransaction = new Domain.Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = request.CreateTransactionDTO.ConsultantId,
                WalletId = wallet.WalletId,
                TransactionType = request.CreateTransactionDTO.TransactionType,
                Description = request.CreateTransactionDTO.Description,
                Amount = request.CreateTransactionDTO.Amount,
                Status = StatusTransaction.Pending,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };

            _transactionRepository.Add(newTransaction);
            await _transactionRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}

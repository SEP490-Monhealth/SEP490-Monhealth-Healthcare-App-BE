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
        public CreateTransactionCommandHandler(ITransactionRepository transactionRepository, 
            IBookingRepository bookingRepository, IMapper mapper)
        {
            _transactionRepository = transactionRepository;
            _bookingRepository = bookingRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateTransactionCommand request, CancellationToken cancellationToken)
        {
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
            _transactionRepository.Add(newTransaction);
            await _transactionRepository.SaveChangeAsync();
            return Unit.Value;
        }
    }
}

using MediatR;
using Monhealth.Application.Contracts.PayOS;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Transaction.Commands.CreateBookingSingle
{
    public class BookingSingleHandler(IUserRepository userRepository,
        IPayOSService payOSService,
        ITransactionRepository transactionRepository
        ) : IRequestHandler<BookingSingleRequest, BookingSingleResponse>
    {
        public async Task<BookingSingleResponse> Handle(BookingSingleRequest request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetUserByIdAsync(request.UserId);
            if (user == null) throw new BadRequestException("Không tìm thấy người dùng");

            var newTransaction = new Domain.Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = user.Id,
                TransactionType = TransactionType.Fee,
                Description = request.Description,
                Amount = request.Amount,
                Status = StatusTransaction.Pending,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };

            var paymentResult = await payOSService.CreatePaymentLinkAsync(
                newTransaction.TransactionId,
                request.Amount,
                request.Description ?? string.Empty
                );

            newTransaction.OrderCode = paymentResult.OrderCode;
            transactionRepository.Add(newTransaction);
            await transactionRepository.SaveChangeAsync();


            return new BookingSingleResponse
            {
                TransactionId = newTransaction.TransactionId,
                UserId = user.Id,
                Amount = (float)newTransaction.Amount,
                Description = newTransaction.Description,
                OrderCode = newTransaction.OrderCode,
                PaymentUrl = paymentResult.CheckoutUrl,
                QrCode = paymentResult.QrCode,
            };
        }
    }
}

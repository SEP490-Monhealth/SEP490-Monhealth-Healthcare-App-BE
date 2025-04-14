using MediatR;
using Monhealth.Application.Contracts.PayOS;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Transaction.Commands.CreateUpgradeSubscriptionPayment
{
    public class CreateUpgradeHandler(IUserRepository userRepository,
            ITransactionRepository transactionRepository,
            IPayOSService payOSService
        ) : IRequestHandler<CreateUpgradeRequest, CreateUpgradeResponse>
    {
        public async Task<CreateUpgradeResponse> Handle(CreateUpgradeRequest request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetUserByIdAsync(request.UserId);
            if (user == null) throw new BadRequestException("Không tìm thấy người dùng");
            var newTransaction = new Domain.Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = request.UserId,
                Amount = request.Amount,
                TransactionType = Domain.Enum.TransactionType.Fee,
                Status = Domain.Enum.StatusTransaction.Pending,
                Description = request.Description,
                SubscriptionId = request.SubscriptionId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = request.UserId,
                UpdatedBy = request.UserId,
            };

            var paymentResult = await payOSService.CreatePaymentLinkAsync(
               newTransaction.TransactionId,
                request.Amount,
                request.Description ?? string.Empty
           );
            newTransaction.OrderCode = paymentResult.OrderCode;
            transactionRepository.Add(newTransaction);
            await transactionRepository.SaveChangeAsync();

            return new CreateUpgradeResponse
            {
                TransactionId = newTransaction.TransactionId,
                UserId = user.Id,
                Amount = newTransaction.Amount,
                Description = newTransaction.Description,
                SubscriptionId = (Guid)newTransaction.SubscriptionId,
                OrderCode = (long)newTransaction.OrderCode,
                PaymentUrl = paymentResult.CheckoutUrl,
                QrCode = paymentResult.QrCode,
            };
        }
    }
}

using MediatR;
using Monhealth.Application.Contracts.PayOS;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Payment.Commands.Create
{
    public class AddPaymentHandler(IPaymentRepository paymentRepository,
        IUserRepository userRepository,
        IPayOSService payOSService

        ) : IRequestHandler<AddPaymentRequest, AddPaymentResponse>
    {
        public async Task<AddPaymentResponse> Handle(AddPaymentRequest request, CancellationToken cancellationToken)
        {
            var user = await userRepository.GetByIdAsync(request.UserId);

            var payment = new Domain.Payment
            {
                PaymentId = Guid.NewGuid(),
                //UserSubscriptionId = request.UserSubscriptionId,
                Amount = request.Amount,
                Status = Core.PaymentStatus.Pending,
                Description = request.Description,
                SubscriptionId = request.SubscriptionId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                CreatedBy = request.UserId,
                UpdatedBy = request.UserId,
            };

            var paymentResult = await payOSService.CreatePaymentLinkAsync(
               payment.PaymentId,
               request.Amount,
               $"Thanh toan don hang"
           );

            paymentRepository.Add(payment);
            await paymentRepository.SaveChangeAsync();

            return new AddPaymentResponse
            {
                PaymentId = payment.PaymentId,
                UserId = user.Id,
                Amount = payment.Amount,
                Description = payment.Description,
                SubscriptionId = (Guid)payment.SubscriptionId,
                Status = payment.Status,
                PaymentUrl = paymentResult.CheckoutUrl,
                QrCode = paymentResult.QrCode,
            };
        }
    }
}


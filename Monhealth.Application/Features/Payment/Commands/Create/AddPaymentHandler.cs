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
                UserSubscriptionId = request.UserSubscriptionId,
                Amount = request.Amount,
                Status = Core.PaymentStatus.Pending,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            var paymentResult = await payOSService.CreatePaymentLinkAsync(
               request.UserSubscriptionId,
               request.Amount,
               $"Thanh toan don hang"
           );

            paymentRepository.Add(payment);
            await paymentRepository.SaveChangeAsync();

            return new AddPaymentResponse
            {
                PaymentId = payment.PaymentId,
                UserSubscriptionId = payment.UserSubscriptionId,
                Amount = payment.Amount,
                Status = payment.Status,
                PaymentUrl = paymentResult.CheckoutUrl,
                QrCode = paymentResult.QrCode,
            };
        }
    }
}


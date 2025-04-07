using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Features.UserSubscription.Commands.Create;
namespace Monhealth.Application.Features.Payment.Commands.UpdateStatusPayments
{
    public class UpdateStatusPaymentHandler(IPaymentRepository paymentRepository,
                IMediator mediator,
                IUserSubscriptionRepository userSubscriptionRepository
        ) : IRequestHandler<UpdateStatusPaymentQueries, bool>
    {
        public async Task<bool> Handle(UpdateStatusPaymentQueries request, CancellationToken cancellationToken)
        {
            var payment = await paymentRepository.GetPayemntByOrderCodeAsync(request.PaymentId);
            if (payment == null)
                throw new BadRequestException($"Không tìm thấy thanh toán : {request.PaymentId}");

            //gọi create usersubsciption 
            var command = new CreateUserSubscriptionCommand
            {
                PaymentId = request.PaymentId,
                SubscriptionId = (Guid)payment.SubscriptionId,
                UserId = (Guid)payment.CreatedBy,
            };
            await mediator.Send(command);

            //assign UserSubscriptionId for payment
            var userSubscription = await userSubscriptionRepository.GetUserSubScriptionByUserIdAndSubscriptionId((Guid)payment.SubscriptionId, (Guid)payment.CreatedBy);
            payment.UserSubscriptionId = userSubscription.UserSubscriptionId;

            // Cập nhật trạng thái thanh toán
            payment.Status = Core.PaymentStatus.Completed;
            await paymentRepository.SaveChangeAsync();
            return true;
        }
    }
}

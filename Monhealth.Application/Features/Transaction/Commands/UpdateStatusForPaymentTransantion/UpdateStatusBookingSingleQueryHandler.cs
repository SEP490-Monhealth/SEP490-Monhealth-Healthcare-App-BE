using MediatR;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Notification;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Features.UserSubscription.Commands.Create;
using Net.payOS.Types;

namespace Monhealth.Application.Features.Transaction.Commands.UpdateStatusForBookingSingle
{
    public class UpdateStatusBookingSingleQueryHandler(ITransactionRepository transactionRepository,
        IUserSubscriptionRepository userSubscriptionRepository,
        IMediator mediator,
        ISystemNotificationService systemNotificationService,
        ILogger<UpdateStatusBookingSingleQueryHandler> logger
        ) : IRequestHandler<UpdateStatusBookingSingleQuery, bool>
    {
        public async Task<bool> Handle(UpdateStatusBookingSingleQuery request, CancellationToken cancellationToken)
        {
            WebhookData webhookData = request.WebhookType.data;
            if (webhookData == null)
            {
                logger.LogWarning("Invalid webhook data received");
                return true;
            }

            var transaction = await transactionRepository.GetTransactionByOrderCode(webhookData.orderCode);
            if (transaction == null) return true;

            if (transaction.SubscriptionId == null) //xử lí update cho thanh toán mua lẻ lượt book
            {
                //get subscriptinon basic 
                var userSubscriptions = await userSubscriptionRepository.GetUserSubscriptionsByUserIdAsync((Guid)transaction.UserId);
                var userSubscription = userSubscriptions.Where(us => us.Status == Core.Enum.UserSubscriptionStatus.Active).FirstOrDefault();
                if (userSubscription == null) return true;

                userSubscription.RemainingBookings += 1;

                //notify user
                await systemNotificationService.NotifySubscriptionBuySingleBooking(transaction, cancellationToken);
            }
            else //xử lí update cho thanh toán nâng cấp gói 
            {
                //gọi create usersubsciption 
                var command = new CreateUserSubscriptionCommand
                {
                    PaymentId = transaction.TransactionId,
                    SubscriptionId = (Guid)transaction.SubscriptionId,
                    UserId = (Guid)transaction.UserId,
                };
                await mediator.Send(command);

                //assign UserSubscriptionId for payment
                var userSubscription = await userSubscriptionRepository.GetUserSubScriptionByUserIdAndSubscriptionId((Guid)transaction.SubscriptionId, (Guid)transaction.UserId);
                transaction.UserSubscriptionId = userSubscription.UserSubscriptionId;

                //notify user
                await systemNotificationService.NotifySubscriptionPurchaseAsync(transaction, userSubscription, cancellationToken);
            }

            transaction.Status = Domain.Enum.StatusTransaction.Completed;
            await transactionRepository.SaveChangeAsync();
            return true;
        }
    }
}

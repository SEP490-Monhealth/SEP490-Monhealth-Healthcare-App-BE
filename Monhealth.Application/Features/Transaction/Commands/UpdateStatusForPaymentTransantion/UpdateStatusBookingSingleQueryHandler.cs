using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Features.UserSubscription.Commands.Create;

namespace Monhealth.Application.Features.Transaction.Commands.UpdateStatusForBookingSingle
{
    public class UpdateStatusBookingSingleQueryHandler(ITransactionRepository transactionRepository,
        IUserSubscriptionRepository userSubscriptionRepository,
        IMediator mediator
        ) : IRequestHandler<UpdateStatusBookingSingleQuery, bool>
    {
        public async Task<bool> Handle(UpdateStatusBookingSingleQuery request, CancellationToken cancellationToken)
        {
            var transaction = await transactionRepository.GetTransactionByOrderCode(request.OrderCode);
            if (transaction == null) throw new BadRequestException("Không tìm thấy giao dịch ");

            if (transaction.SubscriptionId == null) //xử lí update cho thanh toán mua lẻ lượt book
            {
                //get subscriptinon basic 
                var userSubscriptions = await userSubscriptionRepository.GetUserSubscriptionsByUserIdAsync((Guid)transaction.UserId);
                var userSubscription = userSubscriptions.Where(us => us.Status == Core.Enum.UserSubscriptionStatus.Active).FirstOrDefault();
                if (userSubscription == null) throw new BadRequestException("Không tìm thấy gói cơ bản của người dùng");

                userSubscription.RemainingBookings += 1;
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
            }

            transaction.Status = Domain.Enum.StatusTransaction.Completed;
            await transactionRepository.SaveChangeAsync();
            return true;
        }
    }
}

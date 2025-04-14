using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Features.UserSubscription.Commands.Create;

namespace Monhealth.Application.Features.Transaction.Commands.UpdateUpgradeStatus
{
    public class UpdateUpgradeStatusQueryHandler(ITransactionRepository transactionRepository,
            IMediator mediator,
            IUserSubscriptionRepository userSubscriptionRepository
        ) : IRequestHandler<UpdateUpgradeStatusQuery, bool>
    {
        public async Task<bool> Handle(UpdateUpgradeStatusQuery request, CancellationToken cancellationToken)
        {
            var transaction = await transactionRepository.GetTransactionByOrderCode(request.OrderCode);
            if (transaction == null) throw new BadRequestException("Không tìm thấy giao dịch với orderCode này");

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

            // Cập nhật trạng thái thanh toán
            transaction.Status = Domain.Enum.StatusTransaction.Completed;
            await transactionRepository.SaveChangeAsync();
            return true;

        }
    }
}

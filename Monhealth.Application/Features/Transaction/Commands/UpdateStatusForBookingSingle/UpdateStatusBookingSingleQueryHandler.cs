using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;

namespace Monhealth.Application.Features.Transaction.Commands.UpdateStatusForBookingSingle
{
    public class UpdateStatusBookingSingleQueryHandler(ITransactionRepository transactionRepository,
        IUserSubscriptionRepository userSubscriptionRepository
        ) : IRequestHandler<UpdateStatusBookingSingleQuery, bool>
    {
        public async Task<bool> Handle(UpdateStatusBookingSingleQuery request, CancellationToken cancellationToken)
        {
            var transaction = await transactionRepository.GetTransactionByOrderCode(request.OrderCode);
            if (transaction == null) throw new BadRequestException("Không tìm thấy giao dịch ");

            //get subscriptinon basic 
            var userSubscriptions = await userSubscriptionRepository.GetUserSubscriptionsByUserIdAsync((Guid)transaction.UserId);
            var userSubscription = userSubscriptions.Where(us => us.Status == Core.Enum.UserSubscriptionStatus.Active).FirstOrDefault();
            if (userSubscription == null) throw new BadRequestException("Không tìm thấy gói người dùng đã đăng kí");

            userSubscription.RemainingBookings += 1;

            transaction.Status = Domain.Enum.StatusTransaction.Completed;
            await transactionRepository.SaveChangeAsync();
            return true;
        }
    }
}

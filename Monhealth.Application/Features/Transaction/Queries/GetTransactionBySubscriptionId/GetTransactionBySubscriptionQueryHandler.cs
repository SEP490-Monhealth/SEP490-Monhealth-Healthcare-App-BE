using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.Transaction.Queries.GetTransactionBySubscriptionId
{
    public class GetTransactionBySubscriptionQueryHandler(ITransactionRepository transactionRepository,
        IUserRepository userRepository
        ) : IRequestHandler<GetTransactionBySubscriptionIdQuery, List<GetTransactionBySubscriptionIdDto>>
    {
        public async Task<List<GetTransactionBySubscriptionIdDto>> Handle(GetTransactionBySubscriptionIdQuery request, CancellationToken cancellationToken)
        {
            var transactions = await transactionRepository.GetTransactionBySubscriptionId(request.SubscriptionId);

            var userIds = transactions.Where(tran => tran.UserSubscription != null)
                .Select(tran => tran.UserSubscription.UserId)
                .Distinct()
                .ToList();

            var users = await userRepository.GetUserByIdsAsync(userIds);

            var userDictionary = users.ToDictionary(user => user.Id);

            var transactionList = transactions.Select(transaction =>
            {
                if (transaction.UserSubscription == null)
                {
                    throw new Exception($"Thanh toán {transaction.TransactionId} không tìm thấy.");
                }

                if (!userDictionary.TryGetValue(transaction.UserSubscription.UserId, out var member))
                {
                    throw new Exception($"User with ID {transaction.UserSubscription.UserId} not found.");
                }

                var memberDTO = new Member
                {
                    AvatarUrl = member.Avatar ?? string.Empty,
                    Email = member.Email ?? string.Empty,
                    FullName = member.FullName ?? string.Empty,
                    PhoneNumber = member.PhoneNumber ?? string.Empty,
                };

                return new GetTransactionBySubscriptionIdDto
                {
                    TransactionId = transaction.TransactionId,
                    UserId = transaction.UserId,
                    WalletId = transaction.WalletId,
                    BookingId = transaction.BookingId,
                    WithdrawalRequestId = transaction.WithdrawalRequestId,
                    TransactionType = transaction.TransactionType,
                    OrderCode = transaction.OrderCode,
                    SubscriptionId = transaction.UserSubscription.SubscriptionId,
                    SubscriptionName = transaction.UserSubscription.Subscription.SubscriptionName,
                    Description = transaction.Description,
                    Amount = (int)transaction.Amount,
                    Status = transaction.Status,
                    CreatedAt = transaction.CreatedAt,
                    UpdatedAt = transaction.UpdatedAt,
                    CreatedBy = transaction.CreatedBy,
                    UpdatedBy = transaction.UpdatedBy
                };
            }).ToList();

            return transactionList;
        }
    }
}

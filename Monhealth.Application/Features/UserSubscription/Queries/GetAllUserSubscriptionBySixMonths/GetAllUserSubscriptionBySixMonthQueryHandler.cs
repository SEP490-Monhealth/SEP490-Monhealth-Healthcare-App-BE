using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
    public class GetAllUserSubscriptionBySixMonthQueryHandler : IRequestHandler<GetAllUserSubscriptionBySixMonthQuery, List<GetAllUserSubscriptionBySixMonthsDTO>>
    {
        private readonly IUserSubscriptionRepository _userSubscriptionRepository;

        public GetAllUserSubscriptionBySixMonthQueryHandler(IUserSubscriptionRepository userSubscriptionRepository)
        {
            _userSubscriptionRepository = userSubscriptionRepository;
        }

        public async Task<List<GetAllUserSubscriptionBySixMonthsDTO>> Handle(GetAllUserSubscriptionBySixMonthQuery request, CancellationToken cancellationToken)
        {
            var startDate = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1).AddMonths(-5);

            var subscriptions = await _userSubscriptionRepository.GetAllUserSubscriptionAsync();

            var filteredSubscriptions = subscriptions
                .Where(s => s.CreatedAt >= startDate && s.CreatedAt <= DateTime.UtcNow);

            var allSubscriptionNames = new List<string> { "Gói Cơ Bản", "Gói Nâng Cao", "Gói Cao Cấp" };

            var subscriptionCounts = filteredSubscriptions
                .GroupBy(s => s.Subscription.SubscriptionName)
                .Select(g => new
                {
                    SubscriptionName = g.Key,
                    Visitors = g.Count()
                })
                .ToList();

            var result = allSubscriptionNames.Select(subscriptionName => new GetAllUserSubscriptionBySixMonthsDTO
            {
                Subscription = subscriptionName,
                Visitors = subscriptionCounts
                    .FirstOrDefault(s => s.SubscriptionName == subscriptionName)?.Visitors ?? 0
            }).ToList();

            return result;
        }

    }
}



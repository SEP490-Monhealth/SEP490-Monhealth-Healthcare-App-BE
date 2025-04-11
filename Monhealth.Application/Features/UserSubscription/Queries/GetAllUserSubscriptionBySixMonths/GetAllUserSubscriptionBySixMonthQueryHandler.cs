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
            
            var startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(-5);

            var subscriptions = await _userSubscriptionRepository.GetAllAsync();

            var filteredSubscriptions = subscriptions
                .Where(s => s.CreatedAt >= startDate && s.CreatedAt <= DateTime.Now);

            var result = filteredSubscriptions
                .GroupBy(s => s.Subscription)
                .Select(g => new GetAllUserSubscriptionBySixMonthsDTO
                {
                    Subscription = g.Key.SubscriptionName, 
                    Visitors = g.Count()
                })
                .ToList();

            return result;
        }
    }
}

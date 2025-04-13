using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
     public class AnalysisUserQueryHandler : IRequestHandler<AnalysisUserQuery, AnalysisUserDTO>
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserSubscriptionRepository _userSubscriptionRepository;

        public AnalysisUserQueryHandler(IUserRepository userRepository, IUserSubscriptionRepository userSubscriptionRepository)
        {
            _userRepository = userRepository;
            _userSubscriptionRepository = userSubscriptionRepository;
        }

        public async Task<AnalysisUserDTO> Handle(AnalysisUserQuery request, CancellationToken cancellationToken)
        {
            DateTime currentMonthStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime nextMonthStart = currentMonthStart.AddMonths(1);
            // Tháng trước: [previousMonthStart, currentMonthStart)
            DateTime previousMonthStart = currentMonthStart.AddMonths(-1);

            int currentTotalUsers = await _userRepository.GetTotalUsersAsync(nextMonthStart, cancellationToken);
            int previousTotalUsers = await _userRepository.GetTotalUsersAsync(currentMonthStart, cancellationToken);

            // --- New Users ---
            int currentNewUsers = await _userRepository.GetNewUsersAsync(currentMonthStart, nextMonthStart, cancellationToken);
            int previousNewUsers = await _userRepository.GetNewUsersAsync(previousMonthStart, currentMonthStart, cancellationToken);

            // --- Visits ---
            int currentVisits = await _userRepository.GetVisitsAsync(currentMonthStart, nextMonthStart, cancellationToken);
            int previousVisits = await _userRepository.GetVisitsAsync(previousMonthStart, currentMonthStart, cancellationToken);

            // --- Subscription Users ---
            int currentSubscriptionCount = await _userSubscriptionRepository.GetTotalSubscriptionUsersAsync(nextMonthStart, cancellationToken);
            int previousSubscriptionCount = await _userSubscriptionRepository.GetTotalSubscriptionUsersAsync(currentMonthStart, cancellationToken);

            // 3. Tính conversion rate:
            // Conversion Rate = (Subscription Users / Total Users) * 100 (cumulative)
            float currentConversionRate = currentTotalUsers > 0 ? (currentSubscriptionCount * 100f / currentTotalUsers) : 0;
            float previousConversionRate = previousTotalUsers > 0 ? (previousSubscriptionCount * 100f / previousTotalUsers) : 0;

            // 4. Hàm tính Growth Rate
            float CalculateGrowth(int current, int previous)
            {
                if (previous == 0)
                {
                    return current == 0 ? 0 : 100;
                }
                return ((current - previous) / (float)previous) * 100;
            }
            float CalculateGrowthFloat(float current, float previous)
            {
                if (previous == 0)
                {
                    return current == 0 ? 0 : 100;
                }
                return ((current - previous) / previous) * 100;
            }

            float totalUsersGrowthRate = CalculateGrowth(currentTotalUsers, previousTotalUsers);
            float newUsersGrowthRate = CalculateGrowth(currentNewUsers, previousNewUsers);
            float totalVisitsGrowthRate = CalculateGrowth(currentVisits, previousVisits);
            float conversionGrowthRate = CalculateGrowthFloat(currentConversionRate, previousConversionRate);

            // 5. Gán kết quả vào DTO
            var analysisUserDTO = new AnalysisUserDTO
            {
                TotalUsers = new TotalUserDTO
                {
                    Count = currentTotalUsers,
                    GrowthRate = totalUsersGrowthRate
                },
                NewUsers = new NewUserDTO
                {
                    Count = currentNewUsers,
                    GrowthRate = newUsersGrowthRate
                },
                TotalVisits= new TotalVisitDTO
                {
                    Count = currentVisits,
                    GrowthRate = totalVisitsGrowthRate
                },
                ConversionRates = new ConversionRateDTO
                {
                    Count = (int)Math.Round(currentConversionRate, 2),
                    GrowthRate = (float)Math.Round(conversionGrowthRate, 2)
                }
            };

            return analysisUserDTO;
        }
    }
    
}
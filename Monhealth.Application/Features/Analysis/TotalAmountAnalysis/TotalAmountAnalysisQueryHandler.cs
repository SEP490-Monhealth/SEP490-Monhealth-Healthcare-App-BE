using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain.Enum;

namespace Monhealth.Application
{
    public class TotalAmountAnalysisDTO
    {
        public TotalUserAnalysisDTO1 TotalUsers { get; set; } = null!;
        public TotalSubscriptionAnalysisDTO TotalSubscriptions { get; set; } = null!;
        public TotalRevenueDTO TotalRevenue { get; set; } = null!;
        public TotalConsultantDTO TotalConsultants { get; set; } = null!;
    }

    public class TotalAmountAnalysisQuery : IRequest<TotalAmountAnalysisDTO> { }

    public class TotalAmountAnalysisQueryHandler :
        IRequestHandler<TotalAmountAnalysisQuery, TotalAmountAnalysisDTO>
    {
        private readonly IUserRepository _userRepository;
        private readonly ITransactionRepository _transactionRepository;
        private readonly IUserSubscriptionRepository _userSubscriptionRepository;

        public TotalAmountAnalysisQueryHandler(
            IUserRepository userRepository,
            ITransactionRepository transactionRepository,
            IUserSubscriptionRepository userSubscriptionRepository)
        {
            _userRepository = userRepository;
            _transactionRepository = transactionRepository;
            _userSubscriptionRepository = userSubscriptionRepository;
        }

        public async Task<TotalAmountAnalysisDTO> Handle(
            TotalAmountAnalysisQuery request,
            CancellationToken cancellationToken)
        {
            // Lấy ngày đầu tháng hiện tại và đầu tháng trước đó dựa trên CreatedAt
            DateTime currentDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime previousDate = currentDate.AddMonths(-1);

            // -------------------------------------------
            // TotalUsers: chỉ tính các user có role "Member" và "Subscription Member" 
            // được tạo trong tháng hiện tại
            int currentMemberCount =
                await _userRepository.GetUserCountByRoleAsync("Member");
            int currentSubMemberCount =
                await _userRepository.GetUserCountByRoleAsync("Subscription Member");
            int currentTotalUsers = currentMemberCount + currentSubMemberCount;

            // TotalUsers của tháng trước (theo CreatedAt)
            int previousMemberCount =
                await _userRepository.GetUserCountByRoleAsync("Member", previousDate);
            int previousSubMemberCount =
                await _userRepository.GetUserCountByRoleAsync("Subscription Member", previousDate);
            int previousTotalUsers = previousMemberCount + previousSubMemberCount;

            var totalUsersDto = new TotalUserAnalysisDTO1
            {
                Count = currentTotalUsers,
                GrowthRate = CalculateGrowthRate(currentTotalUsers, previousTotalUsers)
            };

            // -------------------------------------------
            // TotalSubscriptions: tổng số bản ghi trong userSubscription 
            // với Subscription tên là "Gói Nâng Cao" hoặc "Gói Cao Cấp"
            int currentUserSubsCount =
                await _userSubscriptionRepository.GetUserSubscriptionCountByNamesAsync(
                    new[] { Guid.Parse("E62B480D-16A6-4565-87FA-262870D75F68"),
                    Guid.Parse("51789ABD-BBCC-42EF-9663-F2EA104302BD") });
            int previousUserSubsCount =
                await _userSubscriptionRepository.GetUserSubscriptionCountByNamesAsync(
                    new[] { Guid.Parse("E62B480D-16A6-4565-87FA-262870D75F68"),
                     Guid.Parse("51789ABD-BBCC-42EF-9663-F2EA104302BD") }, previousDate);

            var totalSubscriptionsDto = new TotalSubscriptionAnalysisDTO
            {
                Count = currentUserSubsCount,
                GrowthRate = CalculateGrowthRate(currentUserSubsCount, previousUserSubsCount)
            };

            // -------------------------------------------
            // TotalRevenue: tổng amount của transaction có Status là Complete
            // (giả sử TransactionStatus.Complete được định nghĩa trong enum)
            decimal currentRevenueAmount =
                await _transactionRepository.GetTotalTransactionAmountWithTypeAsync(
                    Domain.Enum.TransactionType.Fee);
            decimal previousRevenueAmount =
                await _transactionRepository.GetTotalTransactionAmountWithTypeAsync(
                    TransactionType.Fee, previousDate);

            var totalRevenueDto = new TotalRevenueDTO
            {
                Count = currentRevenueAmount,
                GrowthRate = CalculateGrowthRate(currentRevenueAmount, previousRevenueAmount)
            };

            // -------------------------------------------
            // TotalConsultants: số user có role "Consultant" theo CreatedAt
            int currentConsultants =
                await _userRepository.GetUserCountByRoleAsync("Consultant");
            int previousConsultants =
                await _userRepository.GetUserCountByRoleAsync("Consultant", previousDate);

            var totalConsultantsDto = new TotalConsultantDTO
            {
                Count = currentConsultants,
                GrowthRate = CalculateGrowthRate(currentConsultants, previousConsultants)
            };

            return new TotalAmountAnalysisDTO
            {
                TotalUsers = totalUsersDto,
                TotalSubscriptions = totalSubscriptionsDto,
                TotalRevenue = totalRevenueDto,
                TotalConsultants = totalConsultantsDto
            };
        }

        private float CalculateGrowthRate(int currentValue, int previousValue)
        {
            if (previousValue == 0)
                return currentValue > 0 ? 100 : 0;
            return ((float)(currentValue - previousValue) / previousValue) * 100;
        }

        // Nếu previousValue == 0 mà currentValue > 0 -> trả về 100%
        private float CalculateGrowthRate(decimal currentValue, decimal previousValue)
        {
            if (previousValue == 0)
                return currentValue > 0 ? 100 : 0;
            return ((float)(currentValue - previousValue) / (float)previousValue) * 100;
        }
    }
}

public class TotalUserAnalysisDTO1
{
    public int Count { get; set; }
    public float GrowthRate { get; set; }
}

public class TotalSubscriptionAnalysisDTO
{
    public int Count { get; set; }
    public float GrowthRate { get; set; }
}

public class TotalRevenueDTO
{
    // Đã đổi sang kiểu decimal để lưu tổng amount
    public decimal Count { get; set; }
    public float GrowthRate { get; set; }
}

public class TotalConsultantDTO
{
    public int Count { get; set; }
    public float GrowthRate { get; set; }
}

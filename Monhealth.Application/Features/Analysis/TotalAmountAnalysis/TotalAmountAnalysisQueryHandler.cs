using MediatR;
using Monhealth.Application.Contracts.Persistence;

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
        private readonly IPaymentRepository _paymentRepository;

        public TotalAmountAnalysisQueryHandler(IUserRepository userRepository,
            IPaymentRepository paymentRepository)
        {
            _userRepository = userRepository;
            _paymentRepository = paymentRepository;
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
            int currentMemberCount = await _userRepository.GetUserCountByRoleAsync("Member");
            int currentSubMemberCount =
                await _userRepository.GetUserCountByRoleAsync("Subscription Member");
            int currentTotalUsers = currentMemberCount + currentSubMemberCount;

            // Total users của tháng trước dựa trên CreatedAt
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
            // TotalSubscriptions: chỉ tính các Payment có Status = Completed
            int currentCompletedPayments =
                await _paymentRepository.GetCompletedPaymentsCountAsync();
            int previousCompletedPayments =
                await _paymentRepository.GetCompletedPaymentsCountAsync(previousDate);

            var totalSubscriptionsDto = new TotalSubscriptionAnalysisDTO
            {
                Count = currentCompletedPayments,
                GrowthRate = CalculateGrowthRate(currentCompletedPayments, previousCompletedPayments)
            };

            // -------------------------------------------
            // TotalRevenue: tổng Amount của Payment có Status = Completed
            decimal currentRevenue = await _paymentRepository.GetTotalRevenueAsync();
            decimal previousRevenue = await _paymentRepository.GetTotalRevenueAsync(previousDate);

            var totalRevenueDto = new TotalRevenueDTO
            {
                Count = (int)currentRevenue,
                GrowthRate = CalculateGrowthRate(currentRevenue, previousRevenue)
            };

            // -------------------------------------------
            // TotalConsultants: số user có role "Consultant" theo CreatedAt
            int currentConsultants = await _userRepository.GetUserCountByRoleAsync("Consultant");
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
            if (previousValue == 0) return 0;
            return ((float)(currentValue - previousValue) / previousValue) * 100;
        }

        private float CalculateGrowthRate(decimal currentValue, decimal previousValue)
        {
            if (previousValue == 0) return 0;
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
    public int Count { get; set; }
    public float GrowthRate { get; set; }
}

public class TotalConsultantDTO
{
    public int Count { get; set; }
    public float GrowthRate { get; set; }
}

using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
    public class GetAllMemberBySixMonthsQueryHandler : IRequestHandler<GetAllMemberBySixMonthsQuery, List<GetAllMemberBySixMonthsDTO>>
    {
        private readonly IUserRepository _userRepository;
        // Nếu cần lấy roleId, có thể inject thêm IRoleRepository, 
        // nhưng trong repository method đã thực hiện lọc theo role "Member".

        public GetAllMemberBySixMonthsQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<GetAllMemberBySixMonthsDTO>> Handle(GetAllMemberBySixMonthsQuery request, CancellationToken cancellationToken)
        {
       
            DateTime currentDate = DateTime.Now; // hoặc DateTime.UtcNow nếu ứng dụng dùng UTC
            DateTime earliestMonth = new DateTime(currentDate.Year, currentDate.Month, 1).AddMonths(-5);

            var users = await _userRepository.GetAllMemberBySixMonths();
            // Lọc lại theo mốc earliestMonth (đảm bảo chỉ lấy member từ earliestMonth trở đi)
            var usersList = users.Where(u => u.CreatedAt.HasValue && u.CreatedAt.Value >= earliestMonth).ToList();

            // 3. Nhóm các user theo tháng tạo (theo định dạng "yyyy-MM")
            var groupByMonth = usersList
                .GroupBy(u => u.CreatedAt.Value.ToString("yyyy-MM"))
                .ToDictionary(g => g.Key, g => g.Count());

            // 4. Tạo danh sách các tháng liên tiếp theo thứ tự tăng dần từ earliestMonth đến tháng hiện tại (6 tháng)
            List<DateTime> monthList = new List<DateTime>();
            for (int i = 0; i < 6; i++)
            {
                monthList.Add(earliestMonth.AddMonths(i));
            }

            // 5. Tính cumulative count theo từng tháng
            int cumulativeCount = 0;
            List<GetAllMemberBySixMonthsDTO> result = new List<GetAllMemberBySixMonthsDTO>();
            foreach (var month in monthList)
            {
                string monthKey = month.ToString("yyyy-MM");
                int countForMonth = groupByMonth.ContainsKey(monthKey) ? groupByMonth[monthKey] : 0;
                cumulativeCount += countForMonth;
                result.Add(new GetAllMemberBySixMonthsDTO
                {
                    Month = monthKey,
                    
                    Count = cumulativeCount
                });
            }

            return result;
        }

    }
}
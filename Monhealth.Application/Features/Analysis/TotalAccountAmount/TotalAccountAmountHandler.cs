using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Microsoft.AspNetCore.Identity;
using Monhealth.Identity.Models;

namespace Monhealth.Application
{
    public class TotalAmountDTO
    {
        public string Month { get; set; } = string.Empty;
        public int Count { get; set; }
    }

    public class TotalAccountAmountQuery : IRequest<List<TotalAmountDTO>> { }

    public class TotalAccountAmountHandler : IRequestHandler<TotalAccountAmountQuery, List<TotalAmountDTO>>
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IUserRepository _userRepository;

        public TotalAccountAmountHandler(IUserRepository userRepository, UserManager<AppUser> userManager)
        {
            _userRepository = userRepository;
            _userManager = userManager;
        }

        public async Task<List<TotalAmountDTO>> Handle(
            TotalAccountAmountQuery request,
            CancellationToken cancellationToken)
        {
            var currentYear = DateTime.UtcNow.Year;
            var currentMonth = DateTime.UtcNow.Month;

            // Lấy tất cả user
            var allUsers = await _userRepository.GetAllAsync();

            // Lọc ra các non-admin user
            var nonAdminUsers = new List<AppUser>();
            foreach (var user in allUsers)
            {
                var roles = await _userManager.GetRolesAsync(user);
                if (!roles.Contains("Admin"))
                {
                    nonAdminUsers.Add(user);
                }
            }

            // Danh sách kết quả cho tất cả các tháng (1 -> 12) của năm hiện tại
            var monthlyCounts = new List<TotalAmountDTO>();
            int cumulativeCount = 0;

            // Duyệt từ tháng 1 đến tháng 12
            for (int month = 1; month <= 12; month++)
            {
                if (month <= currentMonth)
                {
                    // Tính số user mới được tạo trong tháng đó (trong khoảng từ ngày đầu tháng đến ngày cuối tháng)
                    var monthStart = new DateTime(currentYear, month, 1);
                    var monthEnd = monthStart.AddMonths(1).AddDays(-1);
                    int count = nonAdminUsers.Count(u =>
                        u.CreatedAt >= monthStart &&
                        u.CreatedAt <= monthEnd);

                    // Cộng dồn số user (cumulative)
                    cumulativeCount += count;

                    monthlyCounts.Add(new TotalAmountDTO
                    {
                        Month = $"{currentYear}-{month:D2}",
                        Count = cumulativeCount
                    });
                }
                else
                {
                    // Với các tháng chưa đến, trả về giá trị 0
                    monthlyCounts.Add(new TotalAmountDTO
                    {
                        Month = $"{currentYear}-{month:D2}",
                        Count = 0
                    });
                }
            }

            return monthlyCounts;
        }
    }
}

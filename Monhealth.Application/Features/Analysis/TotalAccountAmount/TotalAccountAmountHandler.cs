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

        public async Task<List<TotalAmountDTO>> Handle(TotalAccountAmountQuery request, CancellationToken cancellationToken)
        {
            var currentYear = DateTime.Now.Year;
            var currentMonth = DateTime.Now.Month;

            // Get all users and their roles
            var allUsers = await _userRepository.GetAllAsync();

            // Get the users that don't have the 'admin' role
            var nonAdminUsers = new List<AppUser>();

            foreach (var user in allUsers)
            {
                var roles = await _userManager.GetRolesAsync(user);
                if (!roles.Contains("Admin"))
                {
                    nonAdminUsers.Add(user);
                }
            }

            // List to hold the result for each month
            var monthlyCounts = new List<TotalAmountDTO>();

            // Loop through each month from January to current month (inclusive)
            for (int month = 1; month <= currentMonth; month++)
            {
                var monthStart = new DateTime(currentYear, month, 1);
                var monthEnd = monthStart.AddMonths(1).AddDays(-1); // Last day of the month

                // Count the users that were created in the current month
                var count = nonAdminUsers.Count(u => u.CreatedAt >= monthStart && u.CreatedAt <= monthEnd);

                // Add the result to the monthlyCounts list, even if the count is 0
                monthlyCounts.Add(new TotalAmountDTO
                {
                    Month = $"{currentYear}-{month:D2}", // Format as "YYYY-MM"
                    Count = count // Set count to 0 if no users are found
                });
            }

            // Ensure that every month from January to the current month is included
            return monthlyCounts;
        }
    }
}

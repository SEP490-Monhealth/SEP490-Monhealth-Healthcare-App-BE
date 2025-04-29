using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Identity.Dbcontexts;
using Monhealth.Identity.Models;
using System.Linq.Dynamic.Core;

namespace Monhealth.Identity.Repositories
{

    public class UserRepository : GenericRepository<AppUser, Guid>, IUserRepository
    {
        public UserRepository(MonhealthDbcontext context) : base(context)
        {
        }
        public async Task<List<AppUser>> GetAllMemberBySixMonths()
        {
            var memberRoleIds = await _context.Roles
                .Where(r => r.Name == "Member" || r.Name == "Subscription Member")
                .Select(r => r.Id)
                .ToListAsync();

            if (!memberRoleIds.Any())
            {
                return new List<AppUser>();
            }
            DateTime earliestMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(-5);
            var users = await _context.Users
                            .Where(u => u.CreatedAt.HasValue &&
                                        u.CreatedAt.Value >= earliestMonth &&
                                        _context.UserRoles.Any(ur => ur.UserId == u.Id && memberRoleIds.Contains(ur.RoleId)))
                            .ToListAsync();

            return users;
        }

        public async Task<PaginatedResult<AppUser>> GetAllUserAsync(int page, int limit, string? search, string? role, string? sort, string? order, bool? status, bool admin)
        {
            search = search?.ToLower().Trim();
            IQueryable<AppUser> query = _context.Users
                .Where(u => !_context.UserRoles
                .Any(ur => ur.UserId == u.Id && _context.Roles
                .Any(r => r.Id == ur.RoleId && r.Name == "Consultant")))
                .AsNoTracking();

            // sap xep
            if (!string.IsNullOrEmpty(sort))
            {
                string sorting = $"{sort} {(order?.ToLower() == "desc" ? "descending" : "ascending")}";
                query = query.OrderBy(sorting);
            }

            if (!string.IsNullOrEmpty(search))
            {
                search = search.ToLower();
                query = query.Where(s => (s.PhoneNumber.ToLower().Contains(search) ||
                                          s.Email.ToLower().Contains(search) ||
                                          EF.Functions.Collate(s.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search)));
            }
            if (!string.IsNullOrEmpty(role))
            {
                query = from user in _context.Users
                        join userRole in _context.UserRoles on user.Id equals userRole.UserId
                        join r in _context.Roles on userRole.RoleId equals r.Id
                        where r.Name == role
                        select user;
            }

            if (status.HasValue)
            {
                query = query.Where(s => s.Status == status.Value);
            }

            if (admin)
            {
                var adminRoleId = await _context.Roles
                    .Where(r => r.Name == "Admin")
                    .Select(r => r.Id)
                    .FirstOrDefaultAsync();
                query = query.Where(u => !_context.UserRoles.Any(ur => ur.UserId == u.Id && ur.RoleId == adminRoleId));
            }

            int totalItems = await query.CountAsync();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<AppUser>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<List<Guid>> GetAllUserIds()
        {
            return await _context.Users
                .Where(u => u.Id != null)
                .Select(u => u.Id)
                .ToListAsync();
        }

        public async Task<string> GetAvatarBySenderIdAsync(Guid senderId)
        {
            // build two queries
            var userQ = _context.Users
                .Where(u => u.Id == senderId)
                .Select(u => u.Avatar);

            var consultantQ = _context.Consultants
                .Include(c => c.AppUser)
                .Where(c => c.ConsultantId == senderId)
                .Select(c => c.AppUser.Avatar);

            var avatarUrl = await userQ
                .Union(consultantQ)
                .FirstOrDefaultAsync();

            return avatarUrl;
        }

        public async Task<Dictionary<Guid, string>> GetAvatarsByUserIds(List<Guid> userIds)
        {
            return await _context.Users
                .Where(u => userIds.Contains(u.Id))
                .Select(u => new { u.Id, u.Avatar })
                .ToDictionaryAsync(u => u.Id, u => u.Avatar);
        }

        public async Task<AppUser> GetByPhoneNumberAsync(string phoneNumber)
        {
            return await _context.Users.Include(u => u.UserSubscriptions)
                        .ThenInclude(us => us.Subscription)
                        .Include(u => u.Consultant)
                    .FirstOrDefaultAsync(u => u.PhoneNumber == phoneNumber);
        }

        public async Task<int> GetNewUsersAsync(DateTime start, DateTime end, CancellationToken cancellationToken)
        {
            var targetRoleNames = new[] { "Member", "Subscription Member" };

            // Lấy danh sách target Role IDs
            var targetRoleIds = await _context.Roles
                .Where(r => targetRoleNames.Contains(r.Name))
                .Select(r => r.Id)
                .ToListAsync(cancellationToken);

            // Đếm số user mới đăng ký trong khoảng thời gian [start, end) với các điều kiện tương tự
            return await _context.Users
                .Where(u => u.CreatedAt.HasValue &&
                            u.CreatedAt.Value >= start &&
                            u.CreatedAt.Value < end &&
                            u.Status &&
                            _context.UserRoles.Any(ur => ur.UserId == u.Id && targetRoleIds.Contains(ur.RoleId)))
                .CountAsync(cancellationToken);
        }


        public async Task<int> GetTotalUsersAsync(DateTime cutoff, CancellationToken cancellationToken)
        {
            // Xác định target role names
            var targetRoleNames = new[] { "Member", "Subscription Member" };

            // Lấy danh sách target Role IDs từ bảng Roles
            var targetRoleIds = await _context.Roles
                .Where(r => targetRoleNames.Contains(r.Name))
                .Select(r => r.Id)
                .ToListAsync(cancellationToken);

            return await _context.Users
                        .Where(u => u.CreatedAt.HasValue &&
                                    u.CreatedAt.Value < cutoff &&
                                    u.Status &&
                                    _context.UserRoles.Any(ur => ur.UserId == u.Id && targetRoleIds.Contains(ur.RoleId)))
                        .CountAsync(cancellationToken);
        }


        public async Task<AppUser> GetUSerByAllergyName(string allergyName)
        {
            return await _context.Users
                .Include(u => u.UserAllergies)
                .ThenInclude(ua => ua.Allergy)
                .FirstOrDefaultAsync(u => u.UserAllergies.Any(ua => ua.Allergy.AllergyName == allergyName));
        }

        public async Task<AppUser> GetUserByIdAsync(Guid userId)
        {
            return await _context.Users
                .Include(g => g.Goals)
                .Include(u => u.UserSubscriptions)
            .FirstOrDefaultAsync(u => u.Id == userId);
        }

        public async Task<List<AppUser>> GetUserByIdsAsync(List<Guid> userIds)
        {
            if (userIds == null || !userIds.Any()) return new List<AppUser>();
            return await _context.Users.Where(u => userIds.Contains(u.Id))
                .ToListAsync();
        }

        public async Task<AppUser> GetUSerByNameAsync(string FullName)
        {
            var query = await _context.Users.FirstOrDefaultAsync(u => u.FullName == FullName);
            return query;
        }

        public async Task<AppUser> GetUserByUserId(Guid userId)
        {
            return await _context.Users
                .AsNoTracking()
                .AsSplitQuery()
                .Include(u => u.Goals)
                .Include(u => u.UserAllergies).ThenInclude(ua => ua.Allergy)
                .FirstOrDefaultAsync(u => u.Id == userId);
        }

        public async Task<int> GetUserCountByRoleAsync(string role)
        {
            var count = await (from ur in _context.UserRoles
                               join r in _context.Roles on ur.RoleId equals r.Id
                               where r.Name == role
                               select ur.UserId)
                               .Distinct()
                               .CountAsync();
            return count;
        }

        public async Task<int> GetUserCountByRoleAsync(string role, DateTime targetDate)
        {
            DateTime upperBound = targetDate.AddMonths(1);

            var count = await (from u in _context.Users
                               join ur in _context.UserRoles on u.Id equals ur.UserId
                               join r in _context.Roles on ur.RoleId equals r.Id
                               where r.Name == role &&
                                     u.CreatedAt.HasValue &&
                                     u.CreatedAt.Value >= targetDate &&
                                     u.CreatedAt.Value < upperBound
                               select u.Id)
                               .Distinct()
                               .CountAsync();
            return count;
        }

        public async Task<Dictionary<string, int>> GetUserCountsByRolesAsync()
        {
            var memberRoleIds = await _context.Roles
                .Where(r => r.Name == "Member" || r.Name == "Subscription Member")
                .Select(r => r.Id)
                .ToListAsync();

            var userCounts = new Dictionary<string, int>();

            if (memberRoleIds.Any())
            {
                // Count users who have "Member" and "Subscription Member" roles
                foreach (var roleId in memberRoleIds)
                {
                    int count = await _context.Users
                        .Where(u => _context.UserRoles.Any(ur => ur.UserId == u.Id && ur.RoleId == roleId))
                        .CountAsync();

                    string roleName = roleId == memberRoleIds.FirstOrDefault() ? "Member" : "Subscription Member";
                    userCounts[roleName] = count;
                }
            }

            return userCounts;
        }

        public async Task<Dictionary<string, int>> GetUserCountsByRolesAsync(DateTime targetDate)
        {
            DateTime upperBound = targetDate.AddMonths(1);

            var result = await (
                from u in _context.Users
                join ur in _context.UserRoles on u.Id equals ur.UserId
                join r in _context.Roles on ur.RoleId equals r.Id
                where u.CreatedAt.HasValue &&
                      u.CreatedAt.Value >= targetDate &&
                      u.CreatedAt.Value < upperBound
                group u by r.Name into g
                select new
                {
                    RoleName = g.Key,
                    Count = g.Count()
                }
            ).ToDictionaryAsync(x => x.RoleName, x => x.Count);

            return result;
        }

        public async Task<List<AppUser>> GetUsersByIdsAsync(List<Guid> userIds)
        {
            if (userIds == null || !userIds.Any())
                return new List<AppUser>();

            return await _context.Users
                                 .Where(user => userIds.Contains(user.Id))
                                 .ToListAsync();
        }

        public async Task<int> GetVisitsAsync(DateTime start, DateTime end, CancellationToken cancellationToken)
        {
            // Xác định 2 role cần tính
            var targetRoleNames = new[] { "Member", "Subscription Member" };

            // Lấy danh sách các Role Id tương ứng từ bảng Roles
            var targetRoleIds = await _context.Roles
                .Where(r => targetRoleNames.Contains(r.Name))
                .Select(r => r.Id)
                .ToListAsync(cancellationToken);


            return await _context.Users
                .Where(u => u.CreatedAt.HasValue &&
                            u.CreatedAt.Value >= start &&
                            u.CreatedAt.Value < end &&
                            u.Status &&
                            _context.UserRoles.Any(ur => ur.UserId == u.Id && targetRoleIds.Contains(ur.RoleId)))
                .CountAsync(cancellationToken);
        }


        public async Task<bool> IsEmailDuplicatedAsync(string email)
        {
            var exist = await _context.Users.AnyAsync(u => u.Email == email);
            return exist;
        }

        public async Task<bool> IsPhoneNumberDuplicateAsync(string phoneNumber)
        {
            var exist = await _context.Users.AnyAsync(u => u.PhoneNumber == phoneNumber);
            return exist;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

    }
}

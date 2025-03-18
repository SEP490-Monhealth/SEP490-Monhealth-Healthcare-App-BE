using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Identity.Dbcontexts;
using Monhealth.Identity.Models;

namespace Monhealth.Identity.Repositories
{
    public class UserRepository : GenericRepository<AppUser, Guid>, IUserRepository
    {
        public UserRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<AppUser>> GetAllUserAsync(int page, int limit, string? search, string? role, bool? status)
        {
            search = search?.Trim();
            IQueryable<AppUser> query = _context.Users
     .Where(u => !_context.UserRoles
         .Any(ur => ur.UserId == u.Id && _context.Roles
             .Any(r => r.Id == ur.RoleId && r.Name == "Consultant"))).AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                search = search.ToLower();
                query = query.Where(s => (s.PhoneNumber.ToLower().Contains(search) ||
                                          s.Email.ToLower().Contains(search) ||
                                          s.FullName.ToLower().Contains(search))
                                          );
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

        public async Task<AppUser> GetByPhoneNumberAsync(string phoneNumber)
        {
            return await _context.Users.Include(u => u.UserSubscriptions)
                        .ThenInclude(us => us.Subscription)
                    .FirstOrDefaultAsync(u => u.PhoneNumber == phoneNumber);
        }


        public async Task<AppUser> GetUserByIdAsync(Guid userId)
        {
            return await _context.Users.Include(g => g.Goals)
            .FirstOrDefaultAsync(u => u.Id == userId);
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

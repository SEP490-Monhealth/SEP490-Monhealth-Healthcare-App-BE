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

                                                .AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                search = search.ToLower();
                query = query.Where(s => (s.UserName.ToLower().Contains(search) ||
                                          s.Email.ToLower().Contains(search) ||
                                          s.FullName.ToLower().Contains(search))
                                          );
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

        public Task<PaginatedResult<AppUser>> GetAllUserAsync(int page, int limit, string search, string role, bool status)
        {
            throw new NotImplementedException();
        }

        public async Task<AppUser> GetByPhoneNumberAsync(string phoneNumber)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.PhoneNumber == phoneNumber);
        }

        public Task<AppUser> GetUserByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}

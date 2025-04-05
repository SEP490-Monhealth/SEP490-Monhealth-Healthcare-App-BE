using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class UserDeviceRepository : GenericRepository<UserDevice, Guid>, IUserDeviceRepository
    {
        public UserDeviceRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<UserDevice>> GetAllUserDevices(int page, int limit)
        {
            IQueryable<UserDevice> query = _context.UserDevices.AsQueryable();
            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<UserDevice>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<List<UserDevice>> GetUserDevicesByUserId(Guid userId)
        {
            return await _context.UserDevices.Where(u => u.UserId == userId).ToListAsync();
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

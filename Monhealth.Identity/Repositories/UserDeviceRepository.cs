using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class UserDeviceRepository : GenericRepository<Device, Guid>, IUserDeviceRepository
    {
        public UserDeviceRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Device>> GetAllUserDevices(int page, int limit)
        {
            IQueryable<Device> query = _context.Devices.AsQueryable();
            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Device>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<List<Device>> GetUserDevicesByUserId(Guid userId)
        {
            return await _context.Devices.Where(u => u.UserId == userId).ToListAsync();
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class DeviceRepository : GenericRepository<Device, Guid>, IDeviceRepository
    {
        public DeviceRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Device>> GetAllDevices(int page, int limit)
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

        public async Task<List<Device>> GetAllDevicesByUserId(Guid UserId)
        {
            return await _context.Devices
                .Where(d => d.UserId == UserId && !string.IsNullOrEmpty(d.ExpoPushToken))
                .ToListAsync();
        }

        public async Task<List<Device>> GetDevicesByUserId(Guid userId)
        {
            return await _context.Devices.Where(u => u.UserId == userId).ToListAsync();
        }

        public async Task<Device> GetExpoPushToken(string expoPushToken)
        {
            var checkExpoPushToken = await _context.Devices.FirstOrDefaultAsync(e => e.ExpoPushToken == expoPushToken);
            if (checkExpoPushToken != null)
            {
                await _context.Database.ExecuteSqlRawAsync("UPDATE Devices SET UpdatedAt = GETDATE() WHERE DeviceId = {0}", checkExpoPushToken.DeviceId);
            }
            return checkExpoPushToken;
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

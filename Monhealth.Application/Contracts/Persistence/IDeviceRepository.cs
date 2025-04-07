using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IDeviceRepository : IGenericRepository<Device, Guid>
    {
        Task<PaginatedResult<Device>> GetAllDevices(int page, int limit);
        Task<List<Device>> GetDevicesByUserId(Guid userId);
        Task<Device> GetExpoPushToken(string expoPushToken);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}

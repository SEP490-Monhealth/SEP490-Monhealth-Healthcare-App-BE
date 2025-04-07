using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IUserDeviceRepository : IGenericRepository<Device, Guid>
    {
        Task<PaginatedResult<Device>> GetAllUserDevices(int page, int limit);
        Task<List<Device>> GetUserDevicesByUserId(Guid userId);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}

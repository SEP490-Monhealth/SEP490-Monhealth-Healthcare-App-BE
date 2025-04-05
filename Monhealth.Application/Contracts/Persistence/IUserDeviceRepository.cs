using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IUserDeviceRepository : IGenericRepository<UserDevice, Guid>
    {
        Task<PaginatedResult<UserDevice>> GetAllUserDevices(int page, int limit);
        Task<List<UserDevice>> GetUserDevicesByUserId(Guid userId);
        Task<int> SaveChangeAsync(CancellationToken cancellationToken);
    }
}

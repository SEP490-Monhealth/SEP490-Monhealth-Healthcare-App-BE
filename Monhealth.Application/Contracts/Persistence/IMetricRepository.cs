using Monhealth.Application.Models;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IMetricRepository : IGenericRepository<Metric, Guid>
    {
        Task<PageResult<Metric>> GetAllMetricAsync(Guid? userId, int page, int limit);
        Task<int> SaveChangeAsync();
    }
}

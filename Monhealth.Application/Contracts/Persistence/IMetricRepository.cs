using Monhealth.Application.Models;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IMetricRepository : IGenericRepository<Metric, Guid>
    {
        Task<List<Metric>> GetAllMetricAsync(Guid? userId);
        Task<Metric> GetMetricByUserIdAsync(Guid userId);
        Task<int> SaveChangeAsync();
    }
}

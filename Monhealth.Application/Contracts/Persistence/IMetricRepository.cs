using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IMetricRepository : IGenericRepository<Metric, Guid>
    {
        Task<List<Metric>> GetAllMetricAsync();
        Task<List<Metric>> GetMetricByUserIdAsync(Guid userId);
        Task<Metric> GetMetricByMetricIdUserIdAsync(Guid metricId, Guid userId);
        Task<int> SaveChangeAsync();
        Task<Metric>GetByUserIdAsync(Guid userId);
    }
}

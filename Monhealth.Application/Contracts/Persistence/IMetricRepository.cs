using Monhealth.Application.Models;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IMetricRepository : IGenericRepository<Metric, Guid>
    {
        Task<PageResult<Metric>> GetAllMetricAsync(int page, int limit);
    }
}

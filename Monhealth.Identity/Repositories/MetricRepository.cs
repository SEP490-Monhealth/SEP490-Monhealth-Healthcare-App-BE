using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class MetricRepository : GenericRepository<Metric, Guid>, IMetricRepository
    {
        public MetricRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<List<Metric>> GetAllMetricAsync()
        {
            return await _context.Metrics.ToListAsync();
        }
    }
}

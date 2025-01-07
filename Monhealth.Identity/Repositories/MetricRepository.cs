using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
using System.Collections.Generic;

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

        public async Task<Metric> GetMetricByMetricIdUserIdAsync(Guid metricId, Guid userId)
        {
            return await _context.Metrics.FirstOrDefaultAsync(m => m.MetricId == metricId && m.UserId == userId);
        }

        public async Task<List<Metric>> GetMetricByUserIdAsync(Guid userId)
        {
            return await _context.Metrics.Where(u => u.UserId == userId).ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}

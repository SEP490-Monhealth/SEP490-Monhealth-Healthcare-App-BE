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

        public async Task<List<Metric>> GetAllMetricAsync(Guid? userId)
        {
            IQueryable<Metric> query = _context.Metrics.AsQueryable();
            if (userId != null)
            {
                query = query.Where(u => u.UserId == userId);
            }

            var metrics = await query.ToListAsync();
            return metrics;
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}

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

        public async Task<PageResult<Metric>> GetAllMetricAsync(int page, int limit)
        {
            IQueryable<Metric> query = _context.Metrics.AsQueryable();

            // get total count
            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            var metrics = await query.ToListAsync();
            return new PageResult<Metric>
            {
                Data = metrics,
                TotalItems = totalItems,
            };
        }
    }
}

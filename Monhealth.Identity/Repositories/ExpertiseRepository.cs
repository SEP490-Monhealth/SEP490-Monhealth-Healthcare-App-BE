using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
using Monhealth.Identity.Models;

namespace Monhealth.Identity.Repositories
{
    public class ExpertiseRepository : GenericRepository<Expertise, Guid>, IExpertiseRepository
    {
        public ExpertiseRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Expertise>> GetAllExpertisesAsync(int page, int limit)
        {
            IQueryable<Expertise> query = _context.Expertises.AsQueryable();

            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Expertise>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<Expertise> GetExpertiseByNameAsync(string expertiseName)
        {
            return await _context.Expertises.FirstOrDefaultAsync(n => n.ExpertiseName.ToLower().Trim().Equals(expertiseName.ToLower().Trim()));
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}

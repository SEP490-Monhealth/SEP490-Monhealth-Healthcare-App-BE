using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class ExpertiseRepository : GenericRepository<Expertise, Guid>, IExpertiseRepository
    {
        public ExpertiseRepository(MonhealthDbcontext context) : base(context)
        {
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

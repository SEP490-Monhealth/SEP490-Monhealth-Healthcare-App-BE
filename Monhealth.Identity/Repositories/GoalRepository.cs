using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Identity.Repositories
{
    public class GoalRepository : GenericRepository<Goal, Guid>, IGoalRepository
    {
        public GoalRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}

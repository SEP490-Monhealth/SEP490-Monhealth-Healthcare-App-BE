using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Goal>> GetGoalsByUserIdAsync(Guid userId)
        {
            return await _context.Goals.Where(u => u.UserId == userId).ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}

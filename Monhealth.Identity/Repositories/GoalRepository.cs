﻿using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class GoalRepository : GenericRepository<Goal, Guid>, IGoalRepository
    {
        public GoalRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<Goal> GetByUserIdAsync(Guid userId)
        {
            return await _context.Goals.FirstOrDefaultAsync(u => u.UserId == userId);
        }

        public async Task<List<Goal>> GetGoalsByUserIdAsync(Guid userId)
        {
            return await _context.Goals.Where(u => u.UserId == userId).OrderByDescending(g => g.CreatedAt).ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}

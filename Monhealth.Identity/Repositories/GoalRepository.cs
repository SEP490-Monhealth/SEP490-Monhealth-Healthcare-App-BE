using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class GoalRepository : GenericRepository<Goal, Guid>, IGoalRepository
    {
        public GoalRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<Goal> CheckStatusGoal(Guid userId)
        {
            var activeGoal = await _context.Goals
                                 .Where(g => g.UserId == userId && g.Status == GoalStatus.Active)
                                 .FirstOrDefaultAsync();
            return activeGoal;
        }

        public async Task<float> GetActivityLevelByUserIdAsync(Guid userId)
        {
            var activityLevel = await _context.Metrics
                .Where(m => m.UserId == userId)
                .Select(m => m.ActivityLevel)
                .FirstOrDefaultAsync();

            return activityLevel > 0 ? activityLevel : 1.2f; // Mặc định nếu không có thì set mức thấp nhất (sedentary)
        }


        public async Task<Goal> GetByUserIdAsync(Guid userId)
        {
            return await _context.Goals.FirstOrDefaultAsync(u => u.UserId == userId && u.Status == GoalStatus.Active);
        }

        public async Task<List<Goal>> GetGoalsByUserIdAsync(Guid userId)
        {
            return await _context.Goals.Where(u => u.UserId == userId).OrderByDescending(g => g.CreatedAt).ToListAsync();
        }

        public async Task<Goal> GetCurrentGoalByUserIdAsync(Guid userId)
        {
            return await _context.Goals.Where(u => u.UserId == userId).OrderByDescending(g => g.CreatedAt).FirstOrDefaultAsync(default) ?? null!;
        }

        public async Task<GoalType?> GetGoalTypeByUserIdAsync(Guid userId)
        {
            var goal = await _context.Goals
                            .Where(g => g.UserId == userId)
                            .Select(g => g.GoalType)
                            .FirstOrDefaultAsync();

            return goal;
        }

        public async Task<Metric?> GetUserMetricByUserIdAsync(Guid userId)
        {
            return await _context.Metrics
                  .Where(m => m.UserId == userId)
                  .OrderByDescending(m => m.CreatedAt) // 🛠 Lấy metric mới nhất nếu có nhiều bản ghi
                  .FirstOrDefaultAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<Goal> GetGoalByUserIdAndStatusActive(Guid userId)
        {
            return await _context.Goals.FirstOrDefaultAsync(u => u.UserId == userId && u.Status == GoalStatus.Active);
        }

        public async Task<Goal> GetGoalByUser(Guid userId)
        {
            return await _context.Goals.FirstOrDefaultAsync(u => u.UserId == userId);
        }

        public async Task<Goal?> GetMostRecentActiveGoalAsync(Guid userId)
        {
            return await _context.Goals
                .Where(g => g.UserId == userId)
                .OrderByDescending(g => g.CreatedAt)
                .FirstOrDefaultAsync();
        }

    }
}

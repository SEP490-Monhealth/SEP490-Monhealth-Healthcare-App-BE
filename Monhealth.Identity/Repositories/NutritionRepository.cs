using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class NutritionRepository : GenericRepository<Nutrition, Guid>, INutritionRepository
    {
        public NutritionRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<List<Nutrition>> GetAllNutritionAsync()
        {
            return await _context.Nutritions.ToListAsync();
        }

        public async Task<Nutrition> GetAllNutritionByFoodIdAsync(Guid foodId)
        {
            return await _context.Nutritions.FirstOrDefaultAsync(n => n.FoodId == foodId);
        }

        public async Task<List<Nutrition>> GetByFoodIdAsync(Guid foodId)
        {
            return await _context.Nutritions.Where(n => n.FoodId == foodId).ToListAsync();
        }

        public async Task<Nutrition> GetNutritionByFoodIdAsync(Guid foodId)
        {
           return await _context.Nutritions.FirstOrDefaultAsync(n => n.FoodId == foodId);
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class FoodPortionRepository : GenericRepository<FoodPortion, Guid>, IFoodPortionRepository
    {
        public FoodPortionRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<FoodPortion> GetByFoodIdAsync(Guid foodId)
        {
            return await _context.FoodPortions.FirstOrDefaultAsync(fp => fp.FoodId == foodId);
        }
    }
}

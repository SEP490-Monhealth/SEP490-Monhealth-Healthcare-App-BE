using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class FoodAllergyRepository : GenericRepository<FoodAllergy, Guid>, IFoodAllergyRepository
    {
        public FoodAllergyRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<List<Guid>> GetFoodIdsByAllergyIdsAsync(List<Guid> allergyIds)
        {
            return await _context.FoodAllergies
            .Where(fa => allergyIds.Contains(fa.AllergyId))
            .Select(fa => fa.FoodId)
            .ToListAsync();
        }
    }
}
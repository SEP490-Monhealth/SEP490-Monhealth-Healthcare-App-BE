using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class AllergyRepository : GenericRepository<Allergy, Guid>, IAllergyRepository
    {
        public AllergyRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<bool> CheckIfUserIsAllergicToFoodAsync(Guid user, Guid food)
        {
            return await _context.UserAllergies
           .Where(ua => ua.UserId == user)
           .Join(_context.FoodAllergies,
                 ua => ua.AllergyId,
                 fa => fa.AllergyId,
                 (ua, fa) => new { ua, fa })
           .AnyAsync(joined => joined.fa.FoodId == food);
        }

        public async Task<List<Allergy>> GetByUserId(Guid userId)
        {
            var query = await _context.UserAllergies.
            Where(ua => ua.UserId == userId)
            .Select(ua => ua.Allergy).ToListAsync();
            return query;
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
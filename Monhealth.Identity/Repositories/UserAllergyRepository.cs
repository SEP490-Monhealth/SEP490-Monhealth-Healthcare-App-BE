using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class UserAllergyRepository : GenericRepository<UserAllergy, Guid>, IUserAllergyRepository
    {
        public UserAllergyRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<List<UserAllergy>> GetUserAllergiesByUserId(Guid userId)
        {
            return await _context.UserAllergies.Include(us => us.Allergy)
             .Where(ua => ua.UserId == userId).ToListAsync();
        }

        public async Task<List<Guid>> GetUserAllergiesByUserIdAsync(Guid userId)
        {
            return await _context.UserAllergies
                        .Where(ua => ua.UserId == userId)
                        .Select(ua => ua.AllergyId)
                        .ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
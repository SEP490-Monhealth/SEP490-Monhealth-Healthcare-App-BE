using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
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

        public async Task<PaginatedResult<Allergy>> GetAllAlleriesAsync(int page, int limit, string? search)
        {
            IQueryable<Allergy> query = _context.Allergies.AsNoTracking().AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(a => EF.Functions.Collate(a.AllergyName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()));

            }

            var totalItems = await query.CountAsync();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            return new PaginatedResult<Allergy>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<List<Allergy>> GetAllergiesByList(List<string> allergies)
        {
            return await _context.Allergies
            .Where(a => allergies.Contains(a.AllergyName)).ToListAsync();
        }

        public async Task<List<Guid>> GetAllergyIdsByNamesAsync(IEnumerable<string> allergyNames)
        {
            return await _context.Allergies
                        .Where(a => allergyNames.Contains(a.AllergyName.ToLower()))
                        .Select(a => a.AllergyId)
                        .ToListAsync();
        }

        public async Task<Allergy> GetByNameAsync(string allergyName)
        {
            return await _context.Allergies.FirstOrDefaultAsync(a => a.AllergyName == allergyName);
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
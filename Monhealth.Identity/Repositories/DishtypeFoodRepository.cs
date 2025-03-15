using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
using Monhealth.Identity.Repositories;

namespace Monhealth.Identity
{
    public class DishtypeFoodRepository : GenericRepository<DishTypeFood, Guid>, IDishTypeFoodRepository
    {
        public DishtypeFoodRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
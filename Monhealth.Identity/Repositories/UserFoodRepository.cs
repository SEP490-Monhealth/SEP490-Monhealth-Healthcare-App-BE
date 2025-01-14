using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class UserFoodRepository : GenericRepository<UserFood, Guid>, IUserFoodRepository
    {
        public UserFoodRepository(MonhealthDbcontext context) : base(context)
        {

        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();

        }
    }
}

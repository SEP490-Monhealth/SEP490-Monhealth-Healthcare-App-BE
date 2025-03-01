using Monhealth.Core;
using Monhealth.Identity.Dbcontexts;
using Monhealth.Identity.Repositories;
using Monteith.Application.Contracts.Persistence;

namespace Monhealth.Identity
{
    public class UserCategoryRepository : GenericRepository<UserCategory, Guid>, IUserCategoryRepository
    {
        public UserCategoryRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
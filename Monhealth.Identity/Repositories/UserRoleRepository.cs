using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class UserRoleRepository : GenericRepository<IdentityUserRole<Guid>, Guid>, IUserRoleRepository
    {
        public UserRoleRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<IdentityUserRole<Guid>> GetUserRoleByUserIdAsync(Guid userId)
        {
            return await _context.UserRoles.FirstOrDefaultAsync(us => us.UserId == userId);

        }
        public async Task<IdentityRole<Guid>> GetRoleByNameAsync(string roleName)
        {
            var subscriptionRole = await _context.Roles
                                         .FirstOrDefaultAsync(r => r.Name == "Subscription Member");
            return subscriptionRole;
        }

        public async Task<IdentityRole<Guid>> GetRoleConsultant(string name)
        {
               var subscriptionRole = await _context.Roles
                                         .FirstOrDefaultAsync(r => r.Name == "Consultant");
            return subscriptionRole;
        }
    }

}
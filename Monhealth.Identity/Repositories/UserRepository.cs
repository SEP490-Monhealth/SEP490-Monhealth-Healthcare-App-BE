using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Identity.Dbcontexts;
using Monhealth.Identity.Models;

namespace Monhealth.Identity.Repositories
{
    public class UserRepository : GenericRepository<AppUser, Guid>, IUserRepository
    {
        public UserRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<AppUser> GetByPhoneNumberAsync(string phoneNumber)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.PhoneNumber == phoneNumber);
        }
    }
}

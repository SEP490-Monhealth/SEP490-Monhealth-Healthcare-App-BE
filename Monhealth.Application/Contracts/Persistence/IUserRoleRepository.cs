using Microsoft.AspNetCore.Identity;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IUserRoleRepository : IGenericRepository<IdentityUserRole<Guid>, Guid>
    {
        Task<IdentityUserRole<Guid>> GetUserRoleByUserIdAsync(Guid userId);
        Task<IdentityRole<Guid>> GetRoleByNameAsync(string roleName);
        Task<IdentityRole<Guid>> GetRoleConsultant(string name);
        Task<IdentityRole<Guid>> GetRoleByIdAsync(Guid roleId);
    }
}
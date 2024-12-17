using Monhealth.Application.Models.Paging;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IUserRepository
    {
        Task<AppUser> GetByPhoneNumberAsync(string phoneNumber);
        Task<AppUser> GetUserByUserId(Guid userId);
        Task<PaginatedResult<AppUser>> GetAllUserAsync(int page, int limit, string? search, string? role, bool? status);
    }
}

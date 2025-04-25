using Monhealth.Application.Models.Paging;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IUserRepository : IGenericRepository<AppUser, Guid>
    {
        Task<AppUser> GetByPhoneNumberAsync(string phoneNumber);
        Task<AppUser> GetUserByUserId(Guid userId);
        Task<PaginatedResult<AppUser>> GetAllUserAsync(int page, int limit, string? search, string? role, string? sort, string? order, bool? status);
        Task<int> SaveChangesAsync();
        Task<bool> IsPhoneNumberDuplicateAsync(string phoneNumber);
        Task<bool> IsEmailDuplicatedAsync(string email);
        Task<AppUser> GetUserByIdAsync(Guid userId);
        Task<AppUser> GetUSerByNameAsync(string FullName);
        Task<AppUser> GetUSerByAllergyName(string allergyName);
        Task<List<Guid>> GetAllUserIds();
        Task<List<AppUser>> GetAllMemberBySixMonths();
        Task<Dictionary<Guid, string>> GetAvatarsByUserIds(List<Guid> userIds);
        Task<Dictionary<string, int>> GetUserCountsByRolesAsync();
        Task<Dictionary<string, int>> GetUserCountsByRolesAsync(DateTime targetDate);
        Task<int> GetTotalUsersAsync(DateTime cutoff, CancellationToken cancellationToken);
        Task<int> GetNewUsersAsync(DateTime start, DateTime end, CancellationToken cancellationToken);
        Task<int> GetVisitsAsync(DateTime start, DateTime end, CancellationToken cancellationToken);
        Task<int> GetUserCountByRoleAsync(string role);
        Task<int> GetUserCountByRoleAsync(string role, DateTime targetDate);
        Task<List<AppUser>> GetUsersByIdsAsync(List<Guid> userIds);
        Task<string> GetAvatarBySenderIdAsync(Guid senderId);

    }
}


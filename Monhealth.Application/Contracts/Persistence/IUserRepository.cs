using Monhealth.Application.Models.Paging;
using Monhealth.Identity.Models;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IUserRepository : IGenericRepository<AppUser, Guid>
    {
        Task<AppUser> GetByPhoneNumberAsync(string phoneNumber);
        Task<AppUser> GetUserByUserId(Guid userId);
        Task<PaginatedResult<AppUser>> GetAllUserAsync(int page, int limit, string? search, string? role, bool? status);
        Task<int> SaveChangesAsync();
        Task<bool> IsPhoneNumberDuplicateAsync(string phoneNumber);
        Task<bool> IsEmailDuplicatedAsync(string email);
        Task<AppUser> GetUserByIdAsync(Guid userId);
        Task<AppUser> GetUSerByNameAsync(string FullName);
        Task<AppUser> GetUSerByAllergyName(string allergyName);
        Task<List<Guid>> GetAllUserIds();
      Task<List<AppUser>> GetAllMemberBySixMonths();
        Task<Dictionary<Guid, string>> GetAvatarsByUserIds(List<Guid> userIds);

    }
}

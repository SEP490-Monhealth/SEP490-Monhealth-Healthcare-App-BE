using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core;

namespace Monteith.Application.Contracts.Persistence
{
    public interface IUserCategoryRepository : IGenericRepository<UserCategory,Guid>
    {
        Task<int>SaveChangeAsync();
        Task<List<UserCategory>>GetUserCategoryByUserId(Guid userId);
    }
}
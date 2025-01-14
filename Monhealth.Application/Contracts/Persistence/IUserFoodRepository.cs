using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IUserFoodRepository : IGenericRepository<UserFood, Guid>
    {
        Task<int> SaveChangeAsync();

    }
}

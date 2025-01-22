using Monhealth.Core;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IUserAllergyRepository : IGenericRepository<UserAllergy,Guid>
    {
        Task<List<Guid>>GetUserAllergiesByUserIdAsync(Guid userId);
    }
}
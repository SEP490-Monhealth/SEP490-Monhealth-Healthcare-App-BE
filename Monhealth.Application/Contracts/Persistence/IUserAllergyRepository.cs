using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IUserAllergyRepository : IGenericRepository<UserAllergy,Guid>
    {
        Task<List<Guid>>GetUserAllergiesByUserIdAsync(Guid userId);
        Task<List<UserAllergy>>GetUserAllergiesByUserId(Guid userId);
        Task<int>SaveChangeAsync();
    }
}
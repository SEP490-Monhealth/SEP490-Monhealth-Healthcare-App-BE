using Monhealth.Core;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IAllergyRepository : IGenericRepository<Allergy, Guid>
    {
        Task<int> SaveChangeAsync();
        Task<bool> CheckIfUserIsAllergicToFoodAsync(Guid user, Guid food);
        Task<List<Allergy>> GetByUserId(Guid userId);
        Task<List<Guid>> GetAllergyIdsByNamesAsync(IEnumerable<string> allergyNames);
    }
}
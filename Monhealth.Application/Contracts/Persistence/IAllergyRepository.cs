using Monhealth.Application.Models.Paging;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IAllergyRepository : IGenericRepository<Allergy, Guid>
    {
        Task<int> SaveChangeAsync();
        Task<bool> CheckIfUserIsAllergicToFoodAsync(Guid user, Guid food);
        Task<List<Allergy>> GetByUserId(Guid userId);
        Task<List<Guid>> GetAllergyIdsByNamesAsync(IEnumerable<string> allergyNames);
        Task<List<Allergy>> GetAllergiesByList(List<string> allergies);
        Task<PaginatedResult<Allergy>> GetAllAlleriesAsync(int page, int limit, string? search);
        Task<Allergy>GetByNameAsync(string allergyName);
    }
}
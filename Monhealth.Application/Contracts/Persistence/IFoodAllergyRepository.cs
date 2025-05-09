using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IFoodAllergyRepository : IGenericRepository<FoodAllergy,Guid>
    {
        Task<List<Guid>>GetFoodIdsByAllergyIdsAsync(List<Guid>allergyIds);
    }
}
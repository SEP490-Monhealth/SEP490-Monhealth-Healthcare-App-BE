using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IDishTypeRepository : IGenericRepository<DishType, Guid>
    {
        Task<List<DishType>> GetDishTypesByNames(string[] names);
        Task DeleteDishTypeFoods(Guid id);
    }
}
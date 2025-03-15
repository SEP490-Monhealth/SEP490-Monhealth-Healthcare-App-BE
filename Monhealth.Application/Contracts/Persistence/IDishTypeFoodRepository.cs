using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Identity
{
    public interface IDishTypeFoodRepository : IGenericRepository<DishTypeFood, Guid>
    {
         Task<int>SaveChangeAsync();
    }
}
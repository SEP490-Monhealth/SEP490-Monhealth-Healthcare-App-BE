using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories 
{
    public class CategoryFoodRepository : GenericRepository<CategoryFood, Guid>, ICategoryFoodRepository
    {
        public CategoryFoodRepository(MonhealthDbcontext context) : base(context)
        {
        }
    }
}
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Identity.Repositories
{
    public class FoodPortionRepository : GenericRepository<FoodPortion, Guid>, IFoodPortionRepository
    {
        public FoodPortionRepository(MonhealthDbcontext context) : base(context)
        {
        }
    }
}

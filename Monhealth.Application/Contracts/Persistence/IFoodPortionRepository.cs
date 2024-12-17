using Monhealth.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IFoodPortionRepository : IGenericRepository<FoodPortion, Guid>
    {

    }
}

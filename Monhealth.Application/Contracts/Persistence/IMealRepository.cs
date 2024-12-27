using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IMealRepository : IGenericRepository<Meal, Guid>
    {
        Task<List<Meal>> GetAllMeals();
    }
}
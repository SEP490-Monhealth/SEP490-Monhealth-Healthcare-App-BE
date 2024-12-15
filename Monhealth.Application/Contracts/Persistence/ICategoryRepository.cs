using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IGenericRepository<Category, Guid>
    {
         Task<List<Category>> GetAllCategoryAsync();
    }
}
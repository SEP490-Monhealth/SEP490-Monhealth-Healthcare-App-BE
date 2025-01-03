using Monhealth.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IGoalRepository : IGenericRepository<Goal, Guid>
    {
        Task<List<Goal>> GetGoalsByYserIdAsync(Guid userId);
        Task<int> SaveChangeAsync();
    }
}

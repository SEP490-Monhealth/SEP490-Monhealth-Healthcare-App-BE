using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monhealth.Domain;

namespace Monhealth.Application.Contracts.Persistence
{
    public interface IDailyActivityRepository : IGenericRepository<DailyActivity, Guid>
    {
        Task<DailyActivity> GetDailyActivityByUserIdAndCreateAt(Guid userId, DateTime today);
        Task<int> SaveChangeAsync();
    }
}

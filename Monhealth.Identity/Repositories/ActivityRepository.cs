using Monhealth.Application.Contracts.Persistence;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class ActivityRepository : GenericRepository<Activity, Guid>, IActivityRepository
    {
        public ActivityRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<List<Activity>> GetActivitiesByDailyActivityId(Guid dailyActivityId)
        {
            return await _context.Activities.Include(w => w.Workout).Where(u => u.DailyActivityId == dailyActivityId).ToListAsync();
        }

        public async Task<List<Activity>> GetActivitiesByUserId(Guid userId)
        {
            return await _context.Activities.Where(u => u.UserId == userId).ToListAsync();
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

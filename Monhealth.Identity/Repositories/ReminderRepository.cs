using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Core;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class ReminderRepository : GenericRepository<Reminder, Guid>, IReminderRepository
    {
        public ReminderRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<List<Reminder>> GetAllReminderAsync()
        {
            return await _context.Reminders.Include(r => r.AppUser).ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
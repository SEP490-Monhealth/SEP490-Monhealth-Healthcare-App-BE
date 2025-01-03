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

        public async Task<Reminder> GetReminderById(Guid reminderId)
        {
            return await _context.Reminders.FirstOrDefaultAsync(r => r.ReminderId == reminderId);
        }

        public async Task<List<Reminder>> GetReminderByUser(Guid userId)
        {
            return await _context.Reminders.Where(r => r.UserId == userId).ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
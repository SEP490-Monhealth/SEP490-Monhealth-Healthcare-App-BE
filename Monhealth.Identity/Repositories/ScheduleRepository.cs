using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class ScheduleRepository : GenericRepository<Schedule, Guid>, IScheduleRepository
    {
        public ScheduleRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Schedule>> GetAllScheduleAsync(int page, int limit)
        {
            var query = _context.Schedules.AsQueryable();

            query = query.Include(s => s.ScheduleTimeSlots)
                             .ThenInclude(st => st.TimeSlot)
                          .OrderBy(s => s.RecurringDay);

            int totalItems = await query.CountAsync();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            return new PaginatedResult<Schedule>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };

        }

        public async Task<Schedule> GetScheduleAsync(
                 Guid consultantId,
                 ScheduleType scheduleType,
                 RecurringDay? recurringDay,
                 DateOnly? specificDate)
        {
            IQueryable<Schedule> query = _context.Schedules
                .Include(s => s.ScheduleTimeSlots)
                .ThenInclude(st => st.TimeSlot)
                .Where(s => s.ConsultantId == consultantId && s.ScheduleType == scheduleType)
                .OrderBy(s => s.RecurringDay);

            if (recurringDay.HasValue)
            {
                query = query.Where(s => s.RecurringDay == recurringDay);
            }

            if (specificDate.HasValue)
            {
                query = query.Where(s => s.SpecificDate == specificDate);
            }

            return await query.FirstOrDefaultAsync();
        }

        public async Task<Schedule> GetScheduleByIdAsync(Guid ScheduleId)
        {
            return await _context.Schedules.Include(s => s.ScheduleTimeSlots).ThenInclude(st => st.TimeSlot)
                    .FirstOrDefaultAsync(s => s.ScheduleId == ScheduleId);
        }

        public async Task<List<Schedule>> GetSchedulesByUser(Guid userId, DateOnly? Date, ScheduleType? scheduleType)
        {
            var query = _context.Schedules.Where(s => s.ConsultantId == userId);
            if (Date.HasValue)
            {
                var targetDayOfWeek = (int)Date.Value.DayOfWeek;
                var adjustedDayOfWeek = (targetDayOfWeek + 6) % 7; // This shifts Sunday to 6, Monday to 0, etc. to match with enum Recurring
                query = query.Where(s => s.RecurringDay != null ? (int)s.RecurringDay == adjustedDayOfWeek : s.SpecificDate == Date);
            }
            if (scheduleType.HasValue)
            {
                query = query.Where(t => t.ScheduleType == scheduleType);
            }

            query = query.Include(s => s.ScheduleTimeSlots)
                .ThenInclude(st => st.TimeSlot)
                .OrderBy(s => s.RecurringDay);
            return await query.ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
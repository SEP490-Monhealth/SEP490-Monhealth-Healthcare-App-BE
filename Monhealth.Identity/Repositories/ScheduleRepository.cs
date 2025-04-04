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
            IQueryable<Schedule> query = _context.Schedules.AsQueryable();


            query = query.Include(s => s.ScheduleTimeSlots)
             .ThenInclude(st => st.TimeSlot);
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

        public async Task<Schedule> GetScheduleAsync(Guid consultantId, ScheduleType scheduleType, RecurringDay? recurringDay, DateOnly? specificDate)
        {
            return await _context.Schedules.Include(s => s.ScheduleTimeSlots).ThenInclude(st => st.TimeSlot)
                    .FirstOrDefaultAsync(s => (s.ConsultantId == consultantId
                    && s.ScheduleType == scheduleType
                    && s.RecurringDay == recurringDay)
                    || (s.SpecificDate == specificDate && s.ConsultantId == consultantId)
                    );

        }

        public async Task<Schedule> GetScheduleByIdAsync(Guid ScheduleId)
        {
            return await _context.Schedules.Include(s => s.ScheduleTimeSlots).ThenInclude(st => st.TimeSlot)
                    .FirstOrDefaultAsync(s => s.ScheduleId == ScheduleId);
        }

        public async Task<List<Schedule>> GetSchedulesByUser(Guid userId, DateOnly? Date)
        {
            var query = _context.Schedules.Where(s => s.ConsultantId == userId);
            if (Date.HasValue)
            {
                var targetDayOfWeek = (int)Date.Value.DayOfWeek;
                var adjustedDayOfWeek = (targetDayOfWeek + 6) % 7; // This shifts Sunday to 6, Monday to 0, etc. to match with enum Recurring
                query = query.Where(s => s.RecurringDay != null ? (int)s.RecurringDay == adjustedDayOfWeek : s.SpecificDate == Date);


            }

            query = query.Include(s => s.ScheduleTimeSlots)
                .ThenInclude(st => st.TimeSlot);
            return await query.ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
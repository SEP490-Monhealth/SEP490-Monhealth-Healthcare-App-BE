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

        public async Task<PaginatedResult<Schedule>> GetAllScheduleAsync(int page, int limit, Guid? consultantId, DateOnly? date)
        {
            IQueryable<Schedule> query = _context.Schedules.AsQueryable();
            if (consultantId.HasValue)
                query = query.Where(s => s.ConsultantId == consultantId);
            if (date.HasValue)
                query = query.Where(s => s.CreatedAt.HasValue && s.CreatedAt.Value.Date == date.Value.ToDateTime(new TimeOnly(0, 0)).Date || s.SpecificDate == date);

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

        public async Task<Schedule> GetScheduleAsync(Guid consultantId, ScheduleType scheduleType, RecurringDay recurringDay)
        {
            return await _context.Schedules.Include(s => s.ScheduleTimeSlots).ThenInclude(st => st.TimeSlot)
                    .FirstOrDefaultAsync(s => s.ConsultantId == consultantId
                    && s.ScheduleType == scheduleType
                    && s.RecurringDay == recurringDay);

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
                // query = query.Where(s => s.Date == Date.Value);
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
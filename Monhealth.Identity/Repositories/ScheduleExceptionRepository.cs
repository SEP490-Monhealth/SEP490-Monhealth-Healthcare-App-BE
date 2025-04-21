using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;
namespace Monhealth.Identity.Repositories
{
    public class ScheduleExceptionRepository : GenericRepository<ScheduleException, Guid>, IScheduleExceptionRepository
    {
        public ScheduleExceptionRepository(MonhealthDbcontext context) : base(context)
        {

        }

        public async Task<bool> CheckScheduleIsExceptionAsync(DateOnly date)
        {
            return await _context.ScheduleExceptions.AnyAsync(sk => sk.Date == date);
        }

        public async Task<PaginatedResult<ScheduleException>> GetAllScheduleExceptionsAsync(int page, int limit)
        {
            IQueryable<ScheduleException> query = _context.ScheduleExceptions
            .Include(s => s.Consultant).ThenInclude(us => us.AppUser);
            int totalItems = await query.CountAsync();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<ScheduleException>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<PaginatedResult<ScheduleException>> GetScheduleExceptionByConsultantIdAsync(int page, int limit, Guid consultantId)
        {
            IQueryable<ScheduleException> query = _context.ScheduleExceptions
                .Include(s => s.Consultant)
                .Where(s => s.Consultant.ConsultantId == consultantId);

            int totalItems = await query.CountAsync();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<ScheduleException>
            {
                Items = await query.OrderByDescending(c => c.CreatedAt).ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<ScheduleException> GetScheduleExceptionByIdAsync(Guid scheduleExceptionId)
        {

            return await _context.ScheduleExceptions
                            .Include(s => s.Consultant).ThenInclude(us => us.AppUser)
                            .FirstOrDefaultAsync(s => s.ScheduleExceptionId == scheduleExceptionId);
        }

        public Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}

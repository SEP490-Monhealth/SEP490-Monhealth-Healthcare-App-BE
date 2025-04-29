using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Dbcontexts;
namespace Monhealth.Identity.Repositories
{
    public class ScheduleExceptionRepository : GenericRepository<ScheduleException, Guid>, IScheduleExceptionRepository
    {
        public ScheduleExceptionRepository(MonhealthDbcontext context) : base(context)
        {

        }

        public async Task<ScheduleException> CheckScheduleIsExceptionApproved(Guid? consultantId, DateOnly date)
        {
            return await _context.ScheduleExceptions
                .FirstOrDefaultAsync(se => se.ConsultantId == consultantId && se.Date == date &&
                se.Status == ScheduleExceptionStatus.Approved);
        }

        public async Task<bool> CheckScheduleIsExceptionAsync(Guid consultantId, DateOnly date)
        {
            return await _context.ScheduleExceptions
                .AnyAsync(sk => sk.Date == date &&
                sk.ConsultantId == consultantId &&
                sk.Status == ScheduleExceptionStatus.Approved);

        }

        public async Task<ScheduleException> CheckScheduleIsExceptionPending(Guid? consultantId, DateOnly date)
        {
           return await _context.ScheduleExceptions
                .FirstOrDefaultAsync(se => se.ConsultantId == consultantId && se.Date == date && 
                se.Status == ScheduleExceptionStatus.Pending);
        }

        public async Task<PaginatedResult<ScheduleException>> GetAllScheduleExceptionsAsync(int page, int limit, string? search, ScheduleExceptionStatus? status)
        {
            IQueryable<ScheduleException> query = _context.ScheduleExceptions
            .Include(s => s.Consultant).ThenInclude(us => us.AppUser);

            if (!string.IsNullOrEmpty(search))
            {
                search = search.ToLower().Trim();
                query = query.Where(se => se.ScheduleExceptionId.ToString() == search ||
                    se.ConsultantId.ToString() == search ||
                    EF.Functions.Collate(se.Reason, "SQL_Latin1_General_CP1_CI_AI").Contains(search)
                );
            }

            if (status.HasValue)
            {
                query = query.Where(se => se.Status == status.Value);
            }

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

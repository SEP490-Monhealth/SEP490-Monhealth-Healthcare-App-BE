using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class ReportRepository : GenericRepository<Report, Guid>, IReportRepository
    {
        public ReportRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Report>> GetAllReports(int page, int limit, string? search, StatusReport? statusReport)
        {
            search = search?.Trim();
            IQueryable<Report> query = _context.Reports.AsNoTracking()
                .Include(b => b.Booking)
                .Include(b => b.Booking).ThenInclude(u => u.User)
                .Include(b => b.Booking).ThenInclude(c => c.Consultant).ThenInclude(u => u.AppUser)
                .AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(b => EF.Functions.Collate(b.Booking.Consultant.AppUser.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower())
                                   || b.Booking.Consultant.AppUser.Email.ToLower().Contains(search.ToLower())
                                   || b.Booking.Consultant.AppUser.PhoneNumber.ToLower().Contains(search.ToLower())
                                   || EF.Functions.Collate(b.Booking.User.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower())
                                   || b.Booking.User.Email.ToString().Contains(search.ToLower())
                                   || b.Booking.User.PhoneNumber.ToString().Contains(search.ToLower())
                                   || b.Booking.Consultant.ConsultantId.ToString().ToLower().Contains(search.ToLower())
                                   || b.Booking.User.Id.ToString().Contains(search.ToLower())
                                   || b.ReportId.ToString().Contains(search.ToLower())
                                   || b.BookingId.ToString().Contains(search.ToLower())
                                   );
            }
            if (statusReport.HasValue)
            {
                query = query.Where(b => b.Status == statusReport.Value);
            }
            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Report>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<List<Report>> GetReportByBookingId(Guid bookingId)
        {
            return await _context.Reports
                .Include(b => b.Booking)
                .Include(b => b.Booking).ThenInclude(u => u.User)
                .Include(b => b.Booking).ThenInclude(c => c.Consultant).ThenInclude(u => u.AppUser)
                .Where(r => r.BookingId == bookingId).ToListAsync();
        }

        public async Task<PaginatedResult<Report>> GetReportByConsultantId(Guid consultantId, int page, int limit)
        {
            var query = _context.Reports
                .Include(b => b.Booking)
                .Include(b => b.Booking).ThenInclude(u => u.User)
                .Include(b => b.Booking).ThenInclude(c => c.Consultant).ThenInclude(u => u.AppUser)
                .Where(r => r.Booking.ConsultantId == consultantId);
            var totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            } 
            return new PaginatedResult<Report>
            {
                Items = await query.OrderByDescending(r => r.CreatedAt).ToListAsync(),
                TotalCount = totalItems
            };

        }

        public async Task<Report> GetReportById(Guid reportId)
        {
            return await _context.Reports
                .Include(b => b.Booking)
                .Include(b => b.Booking).ThenInclude(u => u.User)
                .Include(b => b.Booking).ThenInclude(c => c.Consultant).ThenInclude(u => u.AppUser)
                .FirstOrDefaultAsync(r => r.ReportId == reportId);
        }

        public async Task<PaginatedResult<Report>> GetReportByUserId(Guid userId, int page, int limit)
        {
            var query = _context.Reports
                .Include(b => b.Booking)
                .Include(b => b.Booking).ThenInclude(u => u.User)
                .Include(b => b.Booking).ThenInclude(c => c.Consultant)
                .ThenInclude(u => u.AppUser)
                .Where(r => r.Booking.UserId == userId).AsQueryable();
            var totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((int)((page - 1) * limit)).Take((int)limit);
            }
            return new PaginatedResult<Report>
            {
                Items = await query.OrderByDescending(r => r.CreatedAt).ToListAsync(),
                TotalCount = totalItems
            };

        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}

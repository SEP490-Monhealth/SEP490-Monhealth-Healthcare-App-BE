using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Dbcontexts;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Monhealth.Identity.Repositories
{
    public class BookingRepository : GenericRepository<Booking, Guid>, IBookingRepository
    {
        public BookingRepository(MonhealthDbcontext context) : base(context)
        {

        }

        public async Task<PaginatedResult<Booking>> GetAllBookingAsync(int page, int limit, string? search, BookingStatus? status)
        {
            search = search?.Trim();
            IQueryable<Booking> query = _context.Bookings.AsNoTracking()
                .Include(b => b.User)
                .Include(b => b.Consultant).ThenInclude(c => c.AppUser)
                .AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(b => EF.Functions.Collate(b.User.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()) ||
                                   b.Consultant.AppUser.FullName.ToLower().Contains(search.ToLower())
                                   || b.Consultant.AppUser.PhoneNumber.Contains(search)
                                   || b.User.PhoneNumber.Contains(search)
                                   || b.Consultant.ConsultantId.ToString().ToLower().Contains(search.ToLower())
                                   || b.User.Id.ToString().ToLower().Contains(search.ToLower())
                                   );
            }
            if (status.HasValue)
            {
                query = query.Where(b => b.Status == status.Value);
            }
            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Booking>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<List<TimeOnly>> GetBookedTimeAsync(Guid consultantId, DateOnly date)
        {
            return await _context.Bookings
                .Where(b => b.ConsultantId == consultantId && DateOnly.FromDateTime(b.Day) == date)
                .Select(b => TimeOnly.FromDateTime(b.Day))
                .ToListAsync();   //chi lay gio 
        }

        public async Task<Booking> GetBookingByBookingIdAsync(Guid bookingId)
        {
            return await _context.Bookings.Include(b => b.User)
            .Include(b => b.Consultant).ThenInclude(c => c.AppUser)
            .FirstOrDefaultAsync(b => b.BookingId == bookingId);
        }

        public async Task<List<Booking?>> GetBookingByConsultantId(Guid consultantId, DateTime? date)
        {
            var query = _context.Bookings.AsNoTracking()
                .Include(b => b.User)
                .Include(b => b.Consultant)
                .ThenInclude(c => c.AppUser)
                .AsQueryable();
            if (consultantId != Guid.Empty)
            {
                query = query.Where(b => b.ConsultantId == consultantId);
            }

            if (date.HasValue)
            {
                query = query.Where(b => b.Day.Date == date.Value.Date);
            }

            var listBooking = await query.OrderByDescending(b => b.Day).ToListAsync();
            return listBooking;
        }

        public async Task<List<Booking>> GetBookingByConsultantIds(List<Guid> consultantIds)
        {
            return await _context.Bookings
                .Where(b => consultantIds.Contains(b.ConsultantId ?? Guid.Empty))
                .ToListAsync();

        }

        public async Task<List<Booking>> GetBookingByUserId(Guid userId)
        {
            return await _context.Bookings
                   .AsNoTracking()
                   .AsSplitQuery()
                   .Include(b => b.User)
                   .Include(b => b.Consultant).ThenInclude(c => c.AppUser)
                   .Where(b => b.UserId == userId)
                   .ToListAsync();


        }
        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

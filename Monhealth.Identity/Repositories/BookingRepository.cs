using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Dbcontexts;

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
                .Include(r => r.Reviews)
                .Include(b => b.User)
                .Include(b => b.Consultant).ThenInclude(c => c.AppUser)
                .AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(b => EF.Functions.Collate(b.User.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower())
                                   || b.Consultant.AppUser.FullName.ToLower().Contains(search.ToLower())
                                   || b.Consultant.AppUser.PhoneNumber.Contains(search.ToLower())
                                   || b.User.PhoneNumber.Contains(search.ToLower())
                                   || b.User.Email.Contains(search.ToLower())
                                   || b.Consultant.ConsultantId.ToString().ToLower().Contains(search.ToLower())
                                   || b.User.Id.ToString().ToLower().Contains(search.ToLower())
                                   );
            }

            if (status.HasValue)
            {
                query = query.Where(b => b.Status == status.Value);
            }

            // Sắp xếp theo thời gian tạo mới nhất
            query = ApplyCreatedAtSorting(query);

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

        public async Task<List<TimeOnly>> GetBookedTimeAsync(Guid consultantId, DateOnly? date)
        {
            return await _context.Bookings
                .Where(b => b.ConsultantId == consultantId &&
                        b.Day == date &&
                        b.Status != BookingStatus.Cancelled
                       )
                .Select(b => b.StartTime)
                .ToListAsync();   //chi lay gio 
        }

        public async Task<Booking> GetBookingByBookingIdAsync(Guid bookingId)
        {
            return await _context.Bookings
                .Include(b => b.User)
                .Include(r => r.Reviews)
                .Include(b => b.Consultant).ThenInclude(c => c.AppUser)
                .FirstOrDefaultAsync(b => b.BookingId == bookingId);
        }

        public async Task<PaginatedResult<Booking?>> GetBookingByConsultantId(Guid consultantId, int page, int limit, DateTime? date)
        {
            var query = _context.Bookings
                .AsNoTracking()
                .Include(r => r.Reviews)
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
                var dateOnly = DateOnly.FromDateTime(date.Value);
                query = query.Where(b => b.Day == dateOnly);
            }


            // Sắp xếp theo thời gian tạo mới nhất
            //query = ApplyCreatedAtSorting(query);

            //return await query.ToListAsync();
            query = ApplyCreatedAtSorting(query);

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

        public async Task<PaginatedResult<Booking>> GetBookingByConsultantIdMonthly(int page, int limit, Guid consultantId, DateTime from, DateTime to)
        {
            IQueryable<Booking> query = _context.Bookings.AsNoTracking()
                .Include(b => b.User)
                .Include(b => b.Consultant).ThenInclude(c => c.AppUser)
                .AsQueryable();

            query = query.Where(c => c.ConsultantId == consultantId &&
                               (c.Day >= DateOnly.FromDateTime(from) && c.Day < DateOnly.FromDateTime(to)));

            // Sắp xếp theo thời gian tạo mới nhất
            query = ApplyCreatedAtSorting(query);

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

        public async Task<List<Booking>> GetBookingByConsultantIds(List<Guid> consultantIds)
        {
            var query = _context.Bookings
                .Include(r => r.Reviews)
                .Where(b => consultantIds.Contains(b.ConsultantId ?? Guid.Empty));

            // Sắp xếp theo thời gian tạo mới nhất
            query = ApplyCreatedAtSorting(query);

            return await query.ToListAsync();
        }

        public async Task<List<Booking>> GetBookingByUserAndConsultant(Guid userId, Guid consultantId)
        {
            var query = _context.Bookings
                .AsNoTracking()
                .Include(r => r.Reviews)
                .Include(b => b.User)
                .Include(b => b.Consultant)
                .ThenInclude(c => c.AppUser)
                .Where(b => b.UserId == userId && b.ConsultantId == consultantId);

            // Sắp xếp theo thời gian tạo mới nhất
            query = ApplyCreatedAtSorting(query);

            return await query.ToListAsync();
        }

        public async Task<PaginatedResult<Booking>> GetBookingByUserId(Guid userId, int page, int limit)
        {
            var query = _context.Bookings
                   .AsNoTracking()
                   .AsSplitQuery()
                   .Include(r => r.Reviews)
                   .Include(b => b.User)
                   .Include(b => b.Consultant).ThenInclude(c => c.AppUser)
                   .Where(b => b.UserId == userId);

            // Sắp xếp theo thời gian tạo mới nhất
            query = ApplyCreatedAtSorting(query);

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

        public async Task<List<Booking>> GetBookingsByConsultantAndDateRange(Guid consultantId, DateTime from, DateTime to)
        {
            var query = _context.Bookings
                .Where(b => b.ConsultantId == consultantId
                    && b.Day >= DateOnly.FromDateTime(from)
                    && b.Day < DateOnly.FromDateTime(to));

            // Sắp xếp theo thời gian tạo mới nhất
            query = ApplyCreatedAtSorting(query);

            return await query.ToListAsync();
        }

        public async Task<List<Booking>> GetBookingsByConsultantIdAndDate(Guid consultantId, DateOnly date)
        {
            var query = _context.Bookings
                .Where(b => b.ConsultantId == consultantId &&
                    b.Day == date);

            // Sắp xếp theo thời gian tạo mới nhất
            query = ApplyCreatedAtSorting(query);

            return await query.ToListAsync();
        }

        public async Task<List<Booking>> GetBookingsForRemindersAsync(DateTime startTimeMin, DateTime endTimeMax, CancellationToken cancellationToken)
        {
            return await _context.Bookings
                .Include(b => b.User)
                .Include(b => b.Consultant)
                    .ThenInclude(b => b.AppUser)
                .Where(b =>
                    b.Status == BookingStatus.Booked &&
                    !b.NotificationSent30Min &&
                    b.Day == DateOnly.FromDateTime(startTimeMin.Date) &&
                    b.StartTime >= TimeOnly.FromDateTime(startTimeMin) &&
                    b.EndTime <= TimeOnly.FromDateTime(endTimeMax))
                .ToListAsync();
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        /// <summary>
        /// Sắp xếp booking theo thời gian tạo mới nhất (createdAt giảm dần)
        /// </summary>
        private IQueryable<Booking> ApplyCreatedAtSorting(IQueryable<Booking> query)
        {
            return query.OrderByDescending(b => b.CreatedAt);
        }
    }
}
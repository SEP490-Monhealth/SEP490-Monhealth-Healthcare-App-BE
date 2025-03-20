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
                .Include(b => b.User)
                .Include(b => b.Consultant).ThenInclude(c => c.AppUser)
                .AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(b => EF.Functions.Collate(b.User.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()) ||
                                   b.Consultant.AppUser.FullName.ToLower().Contains(search.ToLower())
                                   || b.Consultant.AppUser.PhoneNumber.Contains(search)
                                   || b.User.PhoneNumber.Contains(search)
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

        public async Task<Booking?> GetBookingByConsultantId(Guid consultantId)
        {
            return await _context.Bookings.AsNoTracking()
                 .Include(b => b.User)
                .Include(b => b.Consultant).ThenInclude(c => c.AppUser)
                .Where(b => b.ConsultantId == consultantId)
                .Select(b => new Booking
                {
                    BookingId = b.BookingId,
                    UserId = b.UserId,
                    //Date = b.Date,
                    Notes = b.Notes,
                    Status = b.Status,
                    CreatedAt = b.CreatedAt,
                    UpdatedAt = b.UpdatedAt,
                    CreatedBy = b.CreatedBy,
                    UpdatedBy = b.UpdatedBy,
                }).FirstOrDefaultAsync();
        }

        public async Task<Booking> GetBookingByUserId(Guid userId)
        {
            return await _context.Bookings
                   .AsNoTracking()
                    .Include(b => b.User)
                .Include(b => b.Consultant).ThenInclude(c => c.AppUser)
                   .Where(b => b.UserId == userId)
                   .Select(b => new Booking
                   {
                       BookingId = b.BookingId,
                       UserId = b.UserId,
                       ConsultantId = b.ConsultantId,
                       // Date = b.Date,
                       Notes = b.Notes,
                       Status = b.Status,
                       CreatedAt = b.CreatedAt,
                       UpdatedAt = b.UpdatedAt,
                       CreatedBy = b.CreatedBy,
                       UpdatedBy = b.UpdatedBy,

                   })
                   .FirstOrDefaultAsync() ?? new Booking(); ;


        }
        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

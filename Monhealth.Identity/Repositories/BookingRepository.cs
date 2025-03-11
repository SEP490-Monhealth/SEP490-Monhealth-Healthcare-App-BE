using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class BookingRepository : GenericRepository<Booking, Guid>, IBookingRepository
    {
        public BookingRepository(MonhealthDbcontext context) : base(context)
        {

        }

        public async Task<PaginatedResult<Booking>> GetAllBookingAsync(int page, int limit)
        {
            IQueryable<Booking> query = _context.Bookings.AsQueryable();
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

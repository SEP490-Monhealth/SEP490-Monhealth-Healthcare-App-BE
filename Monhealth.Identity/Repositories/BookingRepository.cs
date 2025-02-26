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

        public Task<PaginatedResult<Booking>> GetAllBookingAsync(int page, int limit)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveChangeAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}

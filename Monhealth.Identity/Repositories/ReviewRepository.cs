using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class ReviewRepository : GenericRepository<Review, Guid>, IReviewRepository
    {
        public ReviewRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Review>> GetAllReviewAsync(int page, int limit, int rating, string search)
        {
            IQueryable<Review> query = _context.Reviews.Include(r => r.User).AsQueryable();
            if (rating > 0)
            {
                query = query.Where(review => review.Rating == rating);
            }
            if (!string.IsNullOrWhiteSpace(search))
            {
                var isGuidSearch = Guid.TryParse(search, out var reviewId);
                query = query.Where(r =>
                    (isGuidSearch && r.ReviewId == reviewId) ||
                    (r.User != null && r.User.FullName != null && r.User.FullName.Contains(search)) ||
                    (r.User != null && r.User.Email != null && r.User.Email.Contains(search))
                );
            }
            query = query.OrderByDescending(r => r.CreatedAt);
            var totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Review>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<List<Review>> GetReviewsByBookingId(Guid bookingId)
        {
            return await _context.Reviews.AsNoTracking().Include(r => r.User)
                .Where(r => r.BookingId == bookingId).ToListAsync();
        }

        public async Task<PaginatedResult<Review>> GetReviewsByConsultant(Guid consultantId, int page, int limit)
        {
            IQueryable<Review> query = _context.Reviews
            .Where(r => r.Booking.Consultant.ConsultantId == consultantId).AsQueryable();
            query = query.OrderByDescending(r => r.CreatedAt);
            var totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Review>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        //public async Task<List<Review>> GetReviewsByConsultant(Guid consultantId)
        //{
        //    var query = await _context.Reviews.
        //    Where(review => review.ConsultantId == consultantId).ToListAsync();
        //    return query;
        //}

        public async Task<PaginatedResult<Review>> GetReviewsByUser(Guid userId, int page, int limit)
        {
            var query = _context.Reviews.
            Where(review => review.UserId == userId);
            var totalItems = await query.CountAsync();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Review>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
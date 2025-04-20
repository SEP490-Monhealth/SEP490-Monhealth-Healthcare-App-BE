using System.Collections.Generic;
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

        public async Task<PaginatedResult<Review>> GetAllReviewAsync(int page, int limit, int rating)
        {
            IQueryable<Review> query = _context.Reviews.Include(r => r.User).AsQueryable();
            if (rating > 0)
            {
                query = query.Where(review => review.Rating == rating);
            }
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
            .Where(r => r.User.Consultant.ConsultantId == consultantId).AsQueryable();
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

        public async Task<List<Review>> GetReviewsByUser(Guid userId)
        {
            var query = await _context.Reviews.
            Where(review => review.UserId == userId).ToListAsync();
            return query;
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
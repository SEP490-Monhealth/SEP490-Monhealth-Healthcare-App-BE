using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class ReviewRepository : GenericRepository<Review, Guid>, IReviewRepository
    {
        public ReviewRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<List<Review>> GetReviewsByConsultant(Guid consultantId)
        {
            var query = await _context.Reviews.
            Where(review => review.ConsultantId == consultantId).ToListAsync();
            return query;
        }

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
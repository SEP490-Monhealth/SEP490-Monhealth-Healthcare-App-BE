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
    }
}
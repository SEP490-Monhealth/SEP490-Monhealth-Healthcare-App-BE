using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class SubscriptionRepository : GenericRepository<Subscription, Guid>, ISubscriptionRepository
    {
        public SubscriptionRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Subscription>> GetAllSubcriptionAsync(int page, int limit, string? search, bool? sort, bool? status)
        {
            search = search?.Trim();
            IQueryable<Subscription> query = _context.Subscriptions.AsQueryable();

            // filter search
            if (!string.IsNullOrEmpty(search))
            {
                // cho phep search khong dau
                query = query.Where(s => EF.Functions.Collate(s.SubscriptionName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()) ||
                                         s.SubscriptionId.ToString().ToLower().Contains(search.ToLower().Trim()));
            }

            if (sort.HasValue)
            {
                if ((bool)sort)
                {
                    query = query.OrderBy(s => s.Price);
                }
                else
                {
                    query = query.OrderByDescending(s => s.Price);
                }
            }
            if (status.HasValue)
            {
                query = query.Where(s => s.Status == status);
            }
            int totalItems = await query.CountAsync();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Subscription>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<Subscription?> GetBasicSubscription()
        {
            return await _context.Subscriptions
          .FirstOrDefaultAsync(s => s.SubscriptionName.ToLower() == "Gói Cơ Bản");
        }

 

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
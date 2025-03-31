using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Core;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class PaymentRepository : GenericRepository<Payment, Guid>, IPaymentRepository
    {
        public PaymentRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Payment>> GetAllPaymentsWithPagination(int page, int limit, string search,
            PaymentStatus? status)
        {
            IQueryable<Payment> query = _context.Payments
              .Include(p => p.UserSubscription)
                    .ThenInclude(us => us.User)
              .Include(p => p.UserSubscription)
                    .ThenInclude(us => us.Subscription)
              .AsQueryable();
            if (status.HasValue)
            {
                query = query.Where(x => x.Status == status);
            }
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(x => x.UserSubscription.User.FullName.Contains(search));
            }
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            var totalItems = await query.CountAsync();
            return new PaginatedResult<Payment>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };

        }

        public async Task<Payment> GetPayemntByOrderCodeAsync(Guid paymentId)
        {
            return await _context.Payments.FirstOrDefaultAsync(p => p.PaymentId == paymentId);
        }

        public async Task<Payment> GetPaymentById(Guid paymentId)
        {
            return await _context.Payments
                .Include(p => p.UserSubscription)
                    .ThenInclude(us => us.User)
                .Include(p => p.UserSubscription)
                    .ThenInclude(us => us.Subscription)
                .FirstOrDefaultAsync(p => p.PaymentId == paymentId);
        }

        public async Task<List<Payment>> GetPaymentByUser(Guid user)
        {
            return await _context.Payments
                  .Include(p => p.UserSubscription)
                    .ThenInclude(us => us.User)
                  .Include(p => p.UserSubscription)
                    .ThenInclude(us => us.Subscription)
                  .Where(p => p.UserSubscription.UserId == user)
                  .ToListAsync();
        }

        public async Task<List<Payment>> GetPaymentBySubscriptionId(Guid subcriptionId)
        {
            return await _context.Payments
                .Include(p => p.UserSubscription)
                    .ThenInclude(us => us.User)
                .Include(p => p.UserSubscription)
                    .ThenInclude(us => us.Subscription)
                .Where(u => u.UserSubscription.SubscriptionId == subcriptionId)
                .ToListAsync();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
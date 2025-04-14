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
                query = query.Where(x => x.PaymentId.ToString().ToLower().Contains(search.ToLower().Trim()) ||
                                         x.UserSubscriptionId.ToString().ToLower().Contains(search.ToLower().Trim()) ||
                                         EF.Functions.Collate(x.UserSubscription.User.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower().Trim()));
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

        public async Task<Payment> GetPayemntByOrderCodeAsync(long orderCode)
        {
            return await _context.Payments
                .Include(p => p.UserSubscription)
                    .ThenInclude(us => us.User)
                .FirstOrDefaultAsync(p => p.OrderCode == orderCode);
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

        public async Task<PaginatedResult<Payment>> GetPaymentByUser(Guid user, int page, int limit)
        {
            //return await _context.Payments
            //      .Include(p => p.UserSubscription)
            //        .ThenInclude(us => us.User)
            //      .Include(p => p.UserSubscription)
            //        .ThenInclude(us => us.Subscription)
            //      .Where(p => p.UserSubscription.UserId == user)
            //      .ToListAsync();

            IQueryable<Payment> query = _context.Payments.Include(p => p.UserSubscription)
                    .ThenInclude(us => us.User)
                    .Include(p => p.UserSubscription)
                    .ThenInclude(us => us.Subscription).AsQueryable();
            query = query.Where(p => p.UserSubscription.UserId == user);
            var totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<Payment>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
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

        public async Task<int> GetCompletedPaymentsCountAsync()
        {
            // Kiểm tra theo enum PaymentStatus.Completed
            return await _context.Payments
                .CountAsync(p => p.Status == PaymentStatus.Completed);
        }

        public async Task<int> GetCompletedPaymentsCountAsync(DateTime targetDate)
        {
            return await _context.Payments
                .CountAsync(p =>
                    p.Status == PaymentStatus.Completed &&
                    p.CreatedAt >= targetDate &&
                    p.UpdatedAt < targetDate.AddMonths(1));
        }

        public async Task<decimal> GetTotalRevenueAsync()
        {
            return await _context.Payments
                .Where(p => p.Status == PaymentStatus.Completed)
                .SumAsync(p => p.Amount);
        }

        public async Task<decimal> GetTotalRevenueAsync(DateTime targetDate)
        {
            return await _context.Payments
                .Where(p =>
                    p.Status == PaymentStatus.Completed &&
                    p.CreatedAt >= targetDate &&
                    p.UpdatedAt < targetDate.AddMonths(1))
                .SumAsync(p => p.Amount);
        }
    }
}
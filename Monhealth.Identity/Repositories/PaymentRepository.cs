using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity.Repositories
{
    public class PaymentRepository : GenericRepository<Payment, Guid>, IPaymentRepository
    {
        public PaymentRepository(MonhealthDbcontext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Payment>> GetAllPaymentsWithPagination(int page, int limit, string search)
        {
            IQueryable<Payment> query = _context.Payments.Include(p => p.User)
            .Include(u => u.Subscription)
            .AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(x => x.User.FullName.Contains(search));
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

        public async Task<Payment> GetPaymentById(Guid paymentId)
        {
            return await _context.Payments.Include(p => p.User)
            .Include(p => p.Subscription)
            .FirstOrDefaultAsync(p => p.PaymentId == paymentId);
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
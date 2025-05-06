using Microsoft.EntityFrameworkCore;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Exceptions;
using Monhealth.Application.Models.Paging;
using Monhealth.Domain;
using Monhealth.Domain.Enum;
using Monhealth.Identity.Dbcontexts;
using System.Globalization;

namespace Monhealth.Identity.Repositories
{
  public class TransactionRepository : GenericRepository<Transaction, Guid>, ITransactionRepository
  {

    public TransactionRepository(MonhealthDbcontext context) : base(context)
    {
    }

    public async Task<PaginatedResult<Transaction>> GetAllTransactionsAsync(int page, int limit, TransactionType? type,
        string? search, StatusTransaction? status)
    {
      search = search?.Trim();
      IQueryable<Transaction> query = _context.Transactions
      .Include(t => t.User)
      .Include(t => t.Consultant).ThenInclude(c => c.AppUser)
      .Include(b => b.Booking).ThenInclude(c => c.Consultant).ThenInclude(u => u.AppUser)
      .Include(b => b.Booking).ThenInclude(u => u.User)
      .AsNoTracking();
      if (!string.IsNullOrEmpty(search))
      {
        search = search.Trim().ToLower();
        query = query.Where(t =>
            t.TransactionId.ToString().Contains(search.ToLower().Trim()) ||
            t.WalletId.ToString().Contains(search.ToLower().Trim()) ||
            t.BookingId.ToString().Contains(search.ToLower().Trim()) ||
            EF.Functions.Collate(t.Wallet.Consultant.AppUser.FullName, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower()) ||
            EF.Functions.Collate(t.Description, "SQL_Latin1_General_CP1_CI_AI").Contains(search.ToLower())
            );
      }
      if (type.HasValue)
      {
        query = query.Where(t => t.TransactionType == type);
      }
      if (status.HasValue)
      {
        query = query.Where(t => t.Status == status);
      }

      query = query.OrderByDescending(t => t.CreatedAt);
      int totalItems = await query.CountAsync();
      if (page > 0 && limit > 0)
      {
        query = query.Skip((page - 1) * limit).Take(limit);
      }

      return new PaginatedResult<Transaction>
      {
        Items = await query.ToListAsync(),
        TotalCount = totalItems
      };
    }

    public async Task<List<Transaction>> GetTransactionByConsultantId(Guid consultantId, DateTime date)
    {
      int dayOfweek = (int)date.DayOfWeek;
      dayOfweek = dayOfweek == 0 ? 7 : dayOfweek;

      var monday = date.Date.AddDays(-dayOfweek + 1);
      var sunday = monday.AddDays(6).AddDays(1);
      return await _context.Transactions
          .Include(w => w.Wallet).ThenInclude(c => c.Consultant)
          .Where(c => c.Wallet.Consultant.ConsultantId == consultantId
           && c.CreatedAt >= monday && c.CreatedAt < sunday)
          .ToListAsync();
    }

    public async Task<PaginatedResult<Transaction>> GetAllTransactionByConsultantId(int page, int limit, Guid Consultant, string? month)
    {
      var query = _context.Transactions
       .Include(c => c.Wallet)
           .ThenInclude(b => b.Consultant)
              .ThenInclude(c => c.AppUser)
       .Include(c => c.Consultant)

        .Where(t => t.ConsultantId == Consultant)
        .AsNoTracking();


      // Nếu có tham số month, áp dụng bộ lọc tháng và năm
      if (!string.IsNullOrEmpty(month))
      {
        DateTime parsedMonth;
        // Modify the format to match the new "yyyy-MM" format
        if (!DateTime.TryParseExact(month, "yyyy-MM", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedMonth))
        {
          throw new BadRequestException("Invalid month format. Expected format: yyyy-MM.");
        }

        int monthToFilter = parsedMonth.Month;
        int yearToFilter = parsedMonth.Year;

        // Filter by month and year, ensuring CreatedAt is not null
        query = query.Where(t => t.CreatedAt.HasValue
                                 && t.CreatedAt.Value.Month == monthToFilter
                                 && t.CreatedAt.Value.Year == yearToFilter);
      }

      query = query.OrderByDescending(t => t.CreatedAt);

      // Lấy tổng số lượng giao dịch cho phân trang
      int totalItems = await query.CountAsync();

      // Áp dụng phân trang (skip và take)
      if (page > 0 && limit > 0)
      {
        query = query.Skip((page - 1) * limit).Take(limit);
      }

      return new PaginatedResult<Transaction>
      {
        Items = await query.ToListAsync(),
        TotalCount = totalItems
      };
    }

    public async Task<PaginatedResult<Transaction>> GetTransactionByCreatedBy(Guid userId, int page, int limit)
    {
      var query = _context.Transactions
          .Include(c => c.Consultant)
          .Include(c => c.User)
          .Include(b => b.Booking)
          .Include(c => c.Wallet).ThenInclude(c => c.Consultant)
          .Where(c => c.UserId == userId && c.TransactionType == TransactionType.Fee)
          .AsNoTracking();

      query = query.OrderByDescending(t => t.CreatedAt);
      int totalItems = await query.CountAsync();

      // Áp dụng phân trang (skip và take)
      if (page > 0 && limit > 0)
      {
        query = query.Skip((page - 1) * limit).Take(limit);
      }

      return new PaginatedResult<Transaction>
      {
        Items = await query.ToListAsync(),
        TotalCount = totalItems
      };
    }

    public async Task<Transaction> GetTransactionById(Guid transactionId)
    {
      return await _context.Transactions
          .Include(t => t.Consultant).ThenInclude(c => c.AppUser)
          .Include(t => t.User)
          .FirstOrDefaultAsync(c => c.TransactionId == transactionId);
    }

    public async Task<Transaction> GetTransactionByOrderCode(long orderCode)
    {
      return await _context.Transactions
          .FirstOrDefaultAsync(t => t.OrderCode == orderCode);
    }

    public async Task<PaginatedResult<Transaction>> GetTransactionByWalletId(int page, int limit, Guid walletId, StatusTransaction? status)
    {
      var query = _context.Transactions
      .Include(c => c.Consultant)
      .Include(w => w.Booking).ThenInclude(c => c.Consultant)
          .ThenInclude(u => u.AppUser)
      .Where(c => c.ConsultantId == walletId)
      .AsQueryable();
      query = query.OrderByDescending(r => r.CreatedAt);

      int totalItems = await query.CountAsync();
      if (status.HasValue)
      {
        query = query.Where(w => w.Status == status.Value);
      }
      if (page > 0 && limit > 0)
      {
        query = query.Skip((page - 1) * limit).Take(limit);
      }
      return new PaginatedResult<Transaction>
      {
        Items = await query.ToListAsync(),
        TotalCount = totalItems
      };
    }

    public async Task<List<Transaction>> GetTransactionsByConsultantAndDateRange(Guid consultantId, DateTime from, DateTime to)
    {
      return await _context.Transactions.Include(w => w.Wallet).ThenInclude(c => c.Consultant)
      //.Where(b => b.Wallet.Consultant.ConsultantId == consultantId && b.CreatedAt >= from && b.CreatedAt < to).ToListAsync();
      //.Where(b => b.Booking.Consultant.ConsultantId == consultantId && b.CreatedAt >= from && b.CreatedAt < to).ToListAsync();
      .Where(b =>
      (
          b.BookingId != null && b.Booking.Consultant.ConsultantId == consultantId
      )
      ||
      (
          b.BookingId == null && b.Wallet.Consultant.ConsultantId == consultantId
      )
  ).Where(b => b.CreatedAt >= from && b.CreatedAt < to).ToListAsync();
    }

    public async Task<Transaction> GetTransactionWhenUpdated(TransactionType transactionType, float amount, StatusTransaction status)
    {
      return await _context.Transactions
          .FirstOrDefaultAsync(t => t.TransactionType == transactionType &&
          t.Amount == amount &&
          t.Status == status);
    }

    public async Task<int> SaveChangeAsync()
    {
      return await _context.SaveChangesAsync();
    }

    public async Task<List<Transaction>> GetTransactionBySubscriptionId(Guid subscriptionId)
    {
      return await _context.Transactions
          .Include(t => t.UserSubscription).ThenInclude(us => us.User)
          .Include(t => t.UserSubscription).ThenInclude(us => us.Subscription)
          .Where(t => t.SubscriptionId == subscriptionId)
          .ToListAsync();
    }

    public async Task<decimal> GetTotalTransactionAmountWithTypeAsync(
         TransactionType type)
    {
      return (decimal)await _context.Transactions
          .Where(t => t.TransactionType == TransactionType.Fee &&
                      t.Status == StatusTransaction.Completed)
          .SumAsync(t => t.Amount);
    }

    public async Task<decimal> GetTotalTransactionAmountWithTypeAsync(
       TransactionType type, DateTime createdAt)
    {
      var startDate = new DateTime(createdAt.Year, createdAt.Month, 1);
      var endDate = startDate.AddMonths(1);

      return (decimal)await _context.Transactions
          .Where(t => t.TransactionType == TransactionType.Fee &&
                      t.CreatedAt >= startDate && t.CreatedAt < endDate && t.Status == StatusTransaction.Completed)
          .SumAsync(t => t.Amount);
    }

    public async Task<Transaction> GetTransactionByBookingId(Guid bookingId)
    {

      return await _context.Transactions
          .Include(t => t.UserSubscription).ThenInclude(us => us.User)
          .Include(t => t.UserSubscription).ThenInclude(us => us.Subscription)
          .FirstOrDefaultAsync(t => t.BookingId == bookingId);
    }

    public async Task ExpireTransactions(Guid[] transactionIds)
    {
      await _context.Transactions
        .Where(t => transactionIds.Contains(t.TransactionId))
        .ExecuteUpdateAsync(e => e.SetProperty(t => t.Status, StatusTransaction.Failed));
    }
  }
}

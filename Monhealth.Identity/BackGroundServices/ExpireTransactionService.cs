using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Domain;

namespace Monhealth.Identity.BackGroundServices;
public class ExpireTransactionService(
  ILogger<ExpireTransactionService> logger,
  IServiceScopeFactory serviceScopeFactory
    ) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await Task.Delay(TimeSpan.FromMinutes(5), stoppingToken);
            using (var scope = serviceScopeFactory.CreateScope())
            {
                ITransactionRepository? transactionRepo = scope.ServiceProvider.GetRequiredService<ITransactionRepository>();
                if (transactionRepo is null)
                {
                    logger.LogInformation($"ExpireTransactionService - Expired 0 records !");
                    continue;
                }

                IEnumerable<Transaction> transactions = await transactionRepo.GetAllAsync();
                if (!transactions.Any())
                {
                    logger.LogInformation($"ExpireTransactionService - Expired 0 records !");
                    continue;
                }

                DateTime dateTimeNow = DateTime.Now;

                IEnumerable<Transaction> filteredTransactions = [..
          transactions
          .Where(t => dateTimeNow.Subtract(t.CreatedAt ?? dateTimeNow).Minutes > 15)
          .Where(t=>t.TransactionType == Domain.Enum.TransactionType.Fee)
          .Where(t => t.Status == Domain.Enum.StatusTransaction.Pending)
                ];
                if (!filteredTransactions.Any())
                {
                    logger.LogInformation($"ExpireTransactionService - Expired 0 records !");
                    continue;
                }

                await transactionRepo.ExpireTransactions([.. filteredTransactions.Select(t => t.TransactionId)]);
                logger.LogInformation($"ExpireTransactionService - Expired {filteredTransactions.Count()} records !");
            }
          ;
        }

    }
    private DateTime GetCurrentVietnamTime()
    {
        DateTime utcNow = DateTime.UtcNow;
        TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time"); // Vietnam Time Zone
        return TimeZoneInfo.ConvertTimeFromUtc(utcNow, vietnamTimeZone);
    }
}

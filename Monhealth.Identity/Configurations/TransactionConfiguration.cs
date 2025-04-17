using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;
using Monhealth.Domain.Enum;

namespace Monhealth.Identity.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasData(

            #region Transaction 1
            new Transaction
            {
                TransactionId = Guid.NewGuid(),
                UserId = Guid.Parse("06114384-3057-49ea-b106-e03c0e0e8f20"),
                WalletId = null,
                BookingId = null,
                WithdrawalRequestId = null,
                UserSubscriptionId = Guid.Parse("7552390b-5fc0-47c1-a103-6539e190619a"),
                SubscriptionId = Guid.Parse("51789ABD-BBCC-42EF-9663-F2EA104302BD"),
                TransactionType = TransactionType.Fee,
                OrderCode = 1744877280658707,
                Description = "Thanh toán Gói Cao Cấp",
                Amount = 899000,
                Status = StatusTransaction.Completed,
                CreatedAt = DateTime.ParseExact("24-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("24-04-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("06114384-3057-49ea-b106-e03c0e0e8f20"),
                UpdatedBy = Guid.Parse("06114384-3057-49ea-b106-e03c0e0e8f20"),
            }
            #endregion
            );
        }
    }
}

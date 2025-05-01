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
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                ConsultantId = null,
                WalletId = null,
                BookingId = null,
                WithdrawalRequestId = null,
                UserSubscriptionId = Guid.Parse("539F85A5-E937-4DE4-C57A-08DD887F2CD1"),
                SubscriptionId = Guid.Parse("51789ABD-BBCC-42EF-9663-F2EA104302BD"),
                TransactionType = TransactionType.Fee,
                OrderCode = 1746083678981093,
                Description = "Thanh toán Gói Cao Cấp",
                Amount = 899000,
                Status = StatusTransaction.Completed,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                CreatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                UpdatedBy = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
            }
            #endregion
            );
        }
    }
}

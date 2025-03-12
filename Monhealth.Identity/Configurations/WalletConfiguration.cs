using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class WalletConfiguration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region Wallet 1
            new Wallet
            {
                WalletId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                Balance = 1000000,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            }
            #endregion
            );
        }
    }
}

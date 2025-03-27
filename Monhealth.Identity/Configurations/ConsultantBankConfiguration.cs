using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class ConsultantBankConfiguration : IEntityTypeConfiguration<ConsultantBank>
    {
        public void Configure(EntityTypeBuilder<ConsultantBank> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region Consultant Bank 1
            new ConsultantBank
            {
                ConsultantBankId = Guid.NewGuid(),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                BankId = Guid.Parse("936666c3-12f6-406b-9de9-8367233aa6ba"),
                AccountNumber = "1890445466",
                AccountName = "Văn Hữu Toàn",
                IsDefault = true,
                // IVerified = true,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            }
            #endregion
            );
        }
    }
}

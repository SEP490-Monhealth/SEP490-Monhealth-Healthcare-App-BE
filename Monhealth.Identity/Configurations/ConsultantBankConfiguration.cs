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
                //Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region Consultant Bank 2
            new ConsultantBank
            {
                ConsultantBankId = Guid.NewGuid(),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                BankId = Guid.Parse("1b4e6597-7d56-4b6d-833d-c17f5755aad1"),
                AccountNumber = "28497112029",
                AccountName = "Văn Hữu Toàn",
                IsDefault = false,
                //Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region Consultant Bank 3
            new ConsultantBank
            {
                ConsultantBankId = Guid.NewGuid(),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                BankId = Guid.Parse("1b4e6597-7d56-4b6d-833d-c17f5755aad1"),
                AccountNumber = "0792766979",
                AccountName = "Văn Hữu Toàn",
                IsDefault = false,
                //Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region Consultant Bank 4
            new ConsultantBank
            {
                ConsultantBankId = Guid.NewGuid(),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                BankId = Guid.Parse("1b4e6597-7d56-4b6d-833d-c17f5755aad1"),
                AccountNumber = "vanhuutoan27",
                AccountName = "Văn Hữu Toàn",
                IsDefault = false,
                //Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            }
            #endregion
            );
        }
    }
}

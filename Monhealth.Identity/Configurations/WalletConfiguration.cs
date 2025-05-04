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

            // Trần Nhật Quang
            #region Wallet 1
            new Wallet
            {
                WalletId = Guid.Parse("3dbc8aed-a146-4b73-90f4-453bfbc2f071"),
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
                Balance = 1160000,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Thịnh
            #region Wallet 2
            new Wallet
            {
                WalletId = Guid.Parse("32cd37ec-1b39-4d25-babd-6c81ef867d2f"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                Balance = 750000,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Quốc Duy
            #region Wallet 3
            new Wallet
            {
                WalletId = Guid.Parse("81140a5a-b05e-4ff2-b0ee-812913aeef23"),
                ConsultantId = Guid.Parse("8d8827cc-904a-4de5-8261-65acdbcb168d"),
                Balance = 678000,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Thế Anh 
            #region Wallet 4
            new Wallet
            {
                WalletId = Guid.Parse("e370ae45-fa9a-4f3d-b06e-649f8caa7e43"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                Balance = 957000,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Xuân Quang 
            #region Wallet 5
            new Wallet
            {
                WalletId = Guid.Parse("af37c11a-4773-4b3f-b5ad-1851ffa48feb"),
                ConsultantId = Guid.Parse("9a40351b-954a-4697-ac3c-c2e35e89702c"),
                Balance = 479000,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Tiến Phát 
            #region Wallet 6
            new Wallet
            {
                WalletId = Guid.Parse("3f02d88c-72be-46df-abb1-5afb9023bfe0"),
                ConsultantId = Guid.Parse("77db6560-34ad-44b5-86ab-c74f9033d5f9"),
                Balance = 937000,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Văn Dũng
            #region Wallet 7
            new Wallet
            {
                WalletId = Guid.Parse("b7d09e14-d5d7-4806-a6f7-e581f792ef1f"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                Balance = 305000,
                Status = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Van Huu Toan Con
            #region Wallet 8
            new Wallet
            {
                WalletId = Guid.Parse("18a1e829-c8f4-4961-a5cb-bbf6ae444cf6"),
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

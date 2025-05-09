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

            // Trần Nhật Quang con1
            #region 1 Quang bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("fe306f4c-7da1-473d-864a-20f3c257d616"),
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
                BankId = Guid.Parse("15f7f657-5e30-4f8c-8223-8833a63a8edc"),
                AccountNumber = "1029384756",
                AccountName = "TRAN NHAT QUANG",
                IsDefault = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region 2 Quang bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("6fc6c1a3-7640-4217-9ad5-c4683519ce8c"),
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
                BankId = Guid.Parse("efcf1a14-b908-4d54-9b2c-8c1b74f53d72"),
                AccountNumber = "5647382910",
                AccountName = "TRAN NHAT QUANG",
                IsDefault = false,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region 3 Quang bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("204cb7dc-11a4-41c2-8904-63e55a022268"),
                ConsultantId = Guid.Parse("6bce17d4-909f-4fad-b125-0074793f22bd"),
                BankId = Guid.Parse("936666c3-12f6-406b-9de9-8367233aa6ba"),
                AccountNumber = "8473625140",
                AccountName = "TRAN NHAT QUANG",
                IsDefault = false,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Phạm Đức Thịnh con2
            #region 1 Thịnh bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("a25001e8-ebd3-476e-bea2-c816709236bc"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                BankId = Guid.Parse("545a7a7c-0798-4e81-accf-faa5950a11a5"),
                AccountNumber = "6758493021",
                AccountName = "PHAM DUC THINH",
                IsDefault = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region 2 Thịnh bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("fe2e2e1c-6ac2-4732-a72a-78438b23328a"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                BankId = Guid.Parse("a34fea3b-0af5-4338-b30f-cc52f8298a48"),
                AccountNumber = "3021948576",
                AccountName = "PHAM DUC THINH",
                IsDefault = false,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region 3 Thịnh bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("e6376836-1472-4324-a3f4-2a14a2b3657a"),
                ConsultantId = Guid.Parse("0a9dad22-7b87-408b-a377-71dbbe004abc"),
                BankId = Guid.Parse("f556f3d0-d48e-41ed-b59f-e4e30fd17606"),
                AccountNumber = "9182736450",
                AccountName = "PHAM DUC THINH",
                IsDefault = false,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Nguyễn Quốc Duy con3
            #region 1 Duy bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("bf5399ea-f841-4d68-9d9b-458b43a54fe5"),
                ConsultantId = Guid.Parse("8d8827cc-904a-4de5-8261-65acdbcb168d"),
                BankId = Guid.Parse("c2a2d97d-57ab-41ca-9e78-8c8283db2bf1"),
                AccountNumber = "3847561920",
                AccountName = "NGUYEN QUOC DUY",
                IsDefault = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region 2 Duy bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("e86bb212-33bc-4ab5-8585-cd5b596b5af6"),
                ConsultantId = Guid.Parse("8d8827cc-904a-4de5-8261-65acdbcb168d"),
                BankId = Guid.Parse("5cc40599-a099-419f-a1c1-1f2c62d148d6"),
                AccountNumber = "4758692013",
                AccountName = "NGUYEN QUOC DUY",
                IsDefault = false,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Đinh Thế Anh con4
            #region 1 Thế Anh bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("69a0ff4b-b075-4bcd-8d32-e5d8319c622c"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                BankId = Guid.Parse("e720d87e-32dd-4bf4-83df-88330a3693ed"),
                AccountNumber = "2837465910",
                AccountName = "DINH THE ANH",
                IsDefault = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region 2 Thế Anh bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("4e4257e3-8404-4670-8c7d-57bfb38b3674"),
                ConsultantId = Guid.Parse("96818b5d-41a2-436b-841a-4aff36116b95"),
                BankId = Guid.Parse("023beea7-01d7-4e7b-8bdb-7fec21fc2474"),
                AccountNumber = "5601928374",
                AccountName = "DINH THE ANH",
                IsDefault = false,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Trần Xuân Quang con5
            #region 1 Xuân Quang bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("9d2ec54d-f40a-4fde-a887-8a8c67665cab"),
                ConsultantId = Guid.Parse("9a40351b-954a-4697-ac3c-c2e35e89702c"),
                BankId = Guid.Parse("d3f7d465-ab57-444e-857f-39b1d88b9a24"),
                AccountNumber = "6192834750",
                AccountName = "TRAN XUAN QUANG",
                IsDefault = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region 2 Xuân Quang bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("e1a57ac7-a489-4549-a88f-694836b35d10"),
                ConsultantId = Guid.Parse("9a40351b-954a-4697-ac3c-c2e35e89702c"),
                BankId = Guid.Parse("3fbdfc62-831e-44eb-894e-8e85e9822970"),
                AccountNumber = "2374658190",
                AccountName = "TRAN XUAN QUANG",
                IsDefault = false,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Nguyễn Tiến Phát con6
            #region 1 Phát bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("3b958470-905a-4de2-9fcd-b813b75737cf"),
                ConsultantId = Guid.Parse("77db6560-34ad-44b5-86ab-c74f9033d5f9"),
                BankId = Guid.Parse("c6c7e448-a759-4843-b15a-64c7eac81a1e"),
                AccountNumber = "3958172640",
                AccountName = "NGUYEN TIEN PHAT",
                IsDefault = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Nguyễn Văn Dũng con7
            #region 1 Dũng bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("641d30de-59b8-41ec-95f2-bbea2b868367"),
                ConsultantId = Guid.Parse("a0385565-b5f4-4ad3-915e-b95558c00f7d"),
                BankId = Guid.Parse("c6268272-e000-4dd9-8393-b20a6cc5fc13"),
                AccountNumber = "6371829045",
                AccountName = "NGUYEN VAN DUNG",
                IsDefault = true,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            // Văn Hữu Toàn con8
            #region 1 Toàn bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("952d2f64-b4e9-4895-81aa-89e60275e956"),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                BankId = Guid.Parse("936666c3-12f6-406b-9de9-8367233aa6ba"),
                AccountNumber = "1890445466",
                AccountName = "VAN HUU TOAN",
                IsDefault = false,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region 2 Toàn bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("268c10f3-4054-4bc2-ac32-e2c402e2f981"),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                BankId = Guid.Parse("1b4e6597-7d56-4b6d-833d-c17f5755aad1"),
                AccountNumber = "28497112029",
                AccountName = "VAN HUU TOAN",
                IsDefault = false,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region 3 Toàn bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("260ee45b-fc7f-42c2-9ee5-628c11f0e4ab"),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                BankId = Guid.Parse("1b4e6597-7d56-4b6d-833d-c17f5755aad1"),
                AccountNumber = "0792766979",
                AccountName = "VAN HUU TOAN",
                IsDefault = false,
                UpdatedAt = today,
                CreatedAt = today,
            },
            #endregion

            #region 4 Toàn bank
            new ConsultantBank
            {
                ConsultantBankId = Guid.Parse("cd588302-18ed-4cf0-bb91-4449b3877fa2"),
                ConsultantId = Guid.Parse("122dc7df-16de-49a3-ab83-5299686f6203"),
                BankId = Guid.Parse("1b4e6597-7d56-4b6d-833d-c17f5755aad1"),
                AccountNumber = "vanhuutoan27",
                AccountName = "VAN HUU TOAN",
                IsDefault = true,
                UpdatedAt = today,
                CreatedAt = today,
            }
            #endregion
            );
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class BankConfiguration : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);
            var admin = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B");

            builder.HasData(

            #region Bank 1
            new Bank
            {
                BankId = Guid.Parse("15f7f657-5e30-4f8c-8223-8833a63a8edc"),
                BankCode = "ABB",
                BankName = "Ngân hàng TMCP An Bình",
                ShortName = "ABBANK",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/ABB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 2
            new Bank
            {
                BankId = Guid.Parse("efcf1a14-b908-4d54-9b2c-8c1b74f53d72"),
                BankCode = "ACB",
                BankName = "Ngân hàng TMCP Á Châu",
                ShortName = "ACB",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/ACB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 3
            new Bank
            {
                BankId = Guid.Parse("7dc4000d-5e15-4281-8edb-7fa329a40b60"),
                BankCode = "BAB",
                BankName = "Ngân hàng TMCP Bắc Á",
                ShortName = "BacABank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/BAB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 4
            new Bank
            {
                BankId = Guid.Parse("936666c3-12f6-406b-9de9-8367233aa6ba"),
                BankCode = "BIDV",
                BankName = "Ngân hàng TMCP Đầu tư và Phát triển Việt Nam",
                ShortName = "BIDV",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/BIDV.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 5
            new Bank
            {
                BankId = Guid.Parse("151efbc9-190c-46d7-b7ba-373de0a112b8"),
                BankCode = "BVB",
                BankName = "Ngân hàng TMCP Bảo Việt",
                ShortName = "BaoVietBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/BVB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 6
            new Bank
            {
                BankId = Guid.Parse("2c96b6ef-8b7b-4908-a0cd-6d8b78f9c608"),
                BankCode = "CAKE",
                BankName = "TMCP Việt Nam Thịnh Vượng - Ngân hàng số CAKE by VPBank",
                ShortName = "CAKE",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/CAKE.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 7
            new Bank
            {
                BankId = Guid.Parse("6a6e9c81-f24f-4a3b-a0de-19cfd2d62d73"),
                BankCode = "CBB",
                BankName = "Ngân hàng Thương mại TNHH MTV Xây dựng Việt Nam",
                ShortName = "CBBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/CBB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 8
            new Bank
            {
                BankId = Guid.Parse("c2a2d97d-57ab-41ca-9e78-8c8283db2bf1"),
                BankCode = "CIMB",
                BankName = "Ngân hàng TNHH MTV CIMB Việt Nam",
                ShortName = "CIMB",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/CIMB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 9
            new Bank
            {
                BankId = Guid.Parse("5cc40599-a099-419f-a1c1-1f2c62d148d6"),
                BankCode = "COOPB",
                BankName = "Ngân hàng Hợp tác xã Việt Nam",
                ShortName = "Co-op Bank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/COOPBANK.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 10
            new Bank
            {
                BankId = Guid.Parse("303659a9-5e6e-4c6a-8a87-7ff72435ef71"),
                BankCode = "DAB",
                BankName = "Ngân hàng TNHH MTV Số Vikki",
                ShortName = "VikkiBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/DOB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 11
            new Bank
            {
                BankId = Guid.Parse("e720d87e-32dd-4bf4-83df-88330a3693ed"),
                BankCode = "DBS",
                BankName = "DBS Bank Ltd - Chi nhánh Thành phố Hồ Chí Minh",
                ShortName = "DBSBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/DBS.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 12
            new Bank
            {
                BankId = Guid.Parse("023beea7-01d7-4e7b-8bdb-7fec21fc2474"),
                BankCode = "EIB",
                BankName = "Ngân hàng TMCP Xuất nhập khẩu Việt Nam",
                ShortName = "Eximbank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/EIB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 13 
            new Bank
            {
                BankId = Guid.Parse("56e5e154-fced-4790-8392-9ff36191a9be"),
                BankCode = "GPB",
                BankName = "Ngân hàng Thương mại TNHH MTV Dầu Khí Toàn Cầu",
                ShortName = "GPBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/GPB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 14
            new Bank
            {
                BankId = Guid.Parse("d3f7d465-ab57-444e-857f-39b1d88b9a24"),
                BankCode = "HDB",
                BankName = "Ngân hàng TMCP Phát triển Thành phố Hồ Chí Minh",
                ShortName = "HDBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/HDB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 15
            new Bank
            {
                BankId = Guid.Parse("3fbdfc62-831e-44eb-894e-8e85e9822970"),
                BankCode = "HLB",
                BankName = "Ngân hàng TNHH MTV Hong Leong Việt Nam",
                ShortName = "Hong Leong Bank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/HLBVN.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 16
            new Bank
            {
                BankId = Guid.Parse("a821a170-7c24-4e9e-be7c-a0e411aeb382"),
                BankCode = "HSBC",
                BankName = "Ngân hàng TNHH MTV HSBC (Việt Nam)",
                ShortName = "HSBC",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/HSBC.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 17
            new Bank
            {
                BankId = Guid.Parse("c6c7e448-a759-4843-b15a-64c7eac81a1e"),
                BankCode = "IBKHCM",
                BankName = "Ngân hàng Công nghiệp Hàn Quốc - Chi nhánh TP. Hồ Chí Minh",
                ShortName = "IBKHCM",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/IBK - HCM.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 18
            new Bank
            {
                BankId = Guid.Parse("513d42d6-8853-4803-9da7-27545c8b097e"),
                BankCode = "IBKHN",
                BankName = "Ngân hàng Công nghiệp Hàn Quốc - Chi nhánh Hà Nội",
                ShortName = "IBKHN",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/IBK - HN.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 19
            new Bank
            {
                BankId = Guid.Parse("1b573f24-57f1-4568-b437-d4ce3710fd0a"),
                BankCode = "IVB",
                BankName = "Ngân hàng TNHH Indovina",
                ShortName = "Indovina Bank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/IVB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 20
            new Bank
            {
                BankId = Guid.Parse("c6268272-e000-4dd9-8393-b20a6cc5fc13"),
                BankCode = "KB",
                BankName = "Ngân hàng Đại chúng TNHH Kasikornbank",
                ShortName = "Kasikornbank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/KBank.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 21
            new Bank
            {
                BankId = Guid.Parse("3e8b0320-c397-4d33-b28c-bd097ee83827"),
                BankCode = "KBKHCM",
                BankName = "Ngân hàng Kookmin - Chi nhánh Thành phố Hồ Chí Minh",
                ShortName = "KookminHCM",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/KBHCM.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 22
            new Bank
            {
                BankId = Guid.Parse("ad58a74a-8c78-4cc8-bc53-c3e0880fe60c"),
                BankCode = "KBKHN",
                BankName = "Ngân hàng Kookmin - Chi nhánh Hà Nội",
                ShortName = "KookminHN",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/KBHN.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 23
            new Bank
            {
                BankId = Guid.Parse("5156cc07-9e72-4e6f-8975-530439746ec1"),
                BankCode = "KLB",
                BankName = "Ngân hàng TMCP Kiên Long",
                ShortName = "KienLongBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/KLB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 24
            new Bank
            {
                BankId = Guid.Parse("e955fa0e-2f6e-4da1-bd56-e91efaaa6a28"),
                BankCode = "LPB",
                BankName = "Ngân hàng TMCP Lộc Phát Việt Nam",
                ShortName = "LPBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/LPB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 25
            new Bank
            {
                BankId = Guid.Parse("545a7a7c-0798-4e81-accf-faa5950a11a5"),
                BankCode = "MB",
                BankName = "Ngân hàng TMCP Quân đội",
                ShortName = "MBBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/MB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 26
            new Bank
            {
                BankId = Guid.Parse("de95b2b6-9d0e-431d-b33f-889dacdd6a4a"),
                BankCode = "MSB",
                BankName = "Ngân hàng TMCP Hàng Hải",
                ShortName = "MSB",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/MSB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 27
            new Bank
            {
                BankId = Guid.Parse("1c7c1098-3f88-43ac-a389-14fcfe964e3f"),
                BankCode = "NAB",
                BankName = "Ngân hàng TMCP Nam Á",
                ShortName = "NamABank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/NAB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 28
            new Bank
            {
                BankId = Guid.Parse("99889ef3-ce10-4ce5-853e-c47c04ff21c6"),
                BankCode = "NCB",
                BankName = "Ngân hàng TMCP Quốc Dân",
                ShortName = "NCB",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/NCB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 29
            new Bank
            {
                BankId = Guid.Parse("b847fb08-bfd1-4bd0-96e6-b63a95a13740"),
                BankCode = "NHB",
                BankName = "Ngân hàng Nonghyup - Chi nhánh Hà Nội",
                ShortName = "Nonghyup",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/NHB HN.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 30
            new Bank
            {
                BankId = Guid.Parse("cfc8300b-8c96-43f7-8f33-686632f45321"),
                BankCode = "OCB",
                BankName = "Ngân hàng TMCP Phương Đông",
                ShortName = "OCB",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/OCB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 31
            new Bank
            {
                BankId = Guid.Parse("63e050ab-91b1-4e9f-a04c-5c249f49b59e"),
                BankCode = "OJB",
                BankName = "Ngân hàng Thương mại TNHH MTV Đại Dương",
                ShortName = "OceanBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/Oceanbank.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 32
            new Bank
            {
                BankId = Guid.Parse("a2e93fd6-a5c1-4f29-8836-18c4eef261e3"),
                BankCode = "PBVN",
                BankName = "Ngân hàng TNHH MTV Public Việt Nam",
                ShortName = "PublicBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/PBVN.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 33
            new Bank
            {
                BankId = Guid.Parse("26e81201-4c3b-436b-8475-848e6b6477f4"),
                BankCode = "PGB",
                BankName = "Ngân hàng TMCP Xăng dầu Petrolimex",
                ShortName = "PGBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/PGB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 34
            new Bank
            {
                BankId = Guid.Parse("ae189055-1931-4572-b335-7c64862fdb08"),
                BankCode = "PVCB",
                BankName = "Ngân hàng TMCP Đại Chúng Việt Nam",
                ShortName = "PVcomBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/PVCB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 35
            new Bank
            {
                BankId = Guid.Parse("4114ba23-87e2-4a74-b09e-9de11ccdc59f"),
                BankCode = "STB",
                BankName = "Ngân hàng TMCP Sài Gòn Thương Tín",
                ShortName = "Sacombank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/STB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 36
            new Bank
            {
                BankId = Guid.Parse("5e5c546d-1766-4d95-b59a-4dbb32ea8359"),
                BankCode = "SCBVN",
                BankName = "Ngân hàng TNHH MTV Standard Chartered Bank Việt Nam",
                ShortName = "Standard Chartered VN",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/SCVN.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 37
            new Bank
            {
                BankId = Guid.Parse("b888fa91-b880-4886-aeb4-8055c3e7df46"),
                BankCode = "SEAB",
                BankName = "Ngân hàng TMCP Đông Nam Á",
                ShortName = "SeABank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/SEAB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 38
            new Bank
            {
                BankId = Guid.Parse("f0d79834-2a2a-4790-8a95-eebedbee29b0"),
                BankCode = "SGB",
                BankName = "Ngân hàng TMCP Sài Gòn Công Thương",
                ShortName = "SaigonBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/SGICB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 39
            new Bank
            {
                BankId = Guid.Parse("0c9e4bcf-bbf6-450d-a582-bd95ab48ecf9"),
                BankCode = "SGCB",
                BankName = "Ngân hàng TMCP Sài Gòn",
                ShortName = "SCB",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/SCB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 40
            new Bank
            {
                BankId = Guid.Parse("831f0b8a-488a-4536-a5f8-430af848fd3f"),
                BankCode = "SHB",
                BankName = "Ngân hàng TMCP Sài Gòn - Hà Nội",
                ShortName = "SHB",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/SHB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 41
            new Bank
            {
                BankId = Guid.Parse("c032374f-6ee7-440f-8a3c-66d11d91fd46"),
                BankCode = "SHBVN",
                BankName = "Ngân hàng TNHH MTV Shinhan Việt Nam",
                ShortName = "ShinhanBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/SHBVN.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 42
            new Bank
            {
                BankId = Guid.Parse("a34fea3b-0af5-4338-b30f-cc52f8298a48"),
                BankCode = "TCB",
                BankName = "Ngân hàng TMCP Kỹ thương Việt Nam",
                ShortName = "Techcombank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/TCB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 43
            new Bank
            {
                BankId = Guid.Parse("2246e1dd-a52d-4b8e-a883-9353d2929e64"),
                BankCode = "TIMO",
                BankName = "Ngân hàng số Timo",
                ShortName = "Timo",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/TIMO.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 44
            new Bank
            {
                BankId = Guid.Parse("1b4e6597-7d56-4b6d-833d-c17f5755aad1"),
                BankCode = "TPB",
                BankName = "Ngân hàng TMCP Tiên Phong",
                ShortName = "TPBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/TPB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 45
            new Bank
            {
                BankId = Guid.Parse("c46f6b36-1aad-4a54-883f-b59d716743dc"),
                BankCode = "UB",
                BankName = "TMCP Việt Nam Thịnh Vượng - Ngân hàng số Ubank by VPBank",
                ShortName = "Ubank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/Ubank.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 46
            new Bank
            {
                BankId = Guid.Parse("0e325001-6de8-42f7-b82d-a181da4db616"),
                BankCode = "UOB",
                BankName = "Ngân hàng United Overseas",
                ShortName = "United Overseas Bank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/UOB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 47
            new Bank
            {
                BankId = Guid.Parse("89b4b558-3734-4b78-a34a-5a5e03cc7165"),
                BankCode = "VAB",
                BankName = "Ngân hàng TMCP Việt Á",
                ShortName = "VietABank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/VAB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 48
            new Bank
            {
                BankId = Guid.Parse("f556f3d0-d48e-41ed-b59f-e4e30fd17606"),
                BankCode = "VARB",
                BankName = "Ngân hàng Nông nghiệp và Phát triển Nông thôn Việt Nam",
                ShortName = "Agribank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/VBA.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 49
            new Bank
            {
                BankId = Guid.Parse("a038fc4a-9db3-4ed1-a378-6ffcaa65c256"),
                BankCode = "VB",
                BankName = "Ngân hàng TMCP Việt Nam Thương Tín",
                ShortName = "VietBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/VIETBANK.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 50
            new Bank
            {
                BankId = Guid.Parse("d1d1f726-649b-4689-8425-c20e67916f6c"),
                BankCode = "VCB",
                BankName = "Ngân hàng TMCP Ngoại thương Việt Nam",
                ShortName = "Vietcombank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/VCB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 51
            new Bank
            {
                BankId = Guid.Parse("1a8ee573-fbcc-4a25-bdf3-20ee841ffeba"),
                BankCode = "VCCB",
                BankName = "Ngân hàng TMCP Bản Việt",
                ShortName = "Ngân hàng Bản Việt",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/VCCB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 52
            new Bank
            {
                BankId = Guid.Parse("b050a967-d448-4dc5-9823-3c293a753a62"),
                BankCode = "VIB",
                BankName = "Ngân hàng TMCP Quốc tế Việt Nam",
                ShortName = "VIB",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/VIB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 53
            new Bank
            {
                BankId = Guid.Parse("aab0b1ac-9a26-4956-a332-85879ee9d45e"),
                BankCode = "VNPTMONEY",
                BankName = "VNPT Money",
                ShortName = "VNPTMoney",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/VNPTMONEY.svg",
                Status = false,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 54
            new Bank
            {
                BankId = Guid.Parse("ec7fb8ad-ccd6-43e0-8346-060a83c4ca74"),
                BankCode = "VPB",
                BankName = "Ngân hàng TMCP Việt Nam Thịnh Vượng",
                ShortName = "VPBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/VPB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 55
            new Bank
            {
                BankId = Guid.Parse("5906bb97-c103-4a88-9ac6-cc31f16b50a1"),
                BankCode = "VRB",
                BankName = "Ngân hàng Liên doanh Việt - Nga",
                ShortName = "VRB",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/VRB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 56
            new Bank
            {
                BankId = Guid.Parse("cd9fb4ac-6533-4e96-a305-151f6fda06ac"),
                BankCode = "VTB",
                BankName = "Ngân hàng TMCP Công thương Việt Nam",
                ShortName = "VietinBank",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/ICB.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 57
            new Bank
            {
                BankId = Guid.Parse("113db758-ab3f-4491-91cc-4e45623c9e14"),
                BankCode = "VTLMONEY",
                BankName = "Viettel Money",
                ShortName = "ViettelMoney",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/VTLMONEY.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            },
            #endregion

            #region Bank 58
            new Bank
            {
                BankId = Guid.Parse("5948309e-0230-410c-a4c4-a9e8df254fc4"),
                BankCode = "WOO",
                BankName = "Ngân hàng TNHH MTV Woori Việt Nam",
                ShortName = "Woori",
                LogoUrl = "https://cdn.banklookup.net/assets/images/bank-icons/WVN.svg",
                Status = true,
                CreatedAt = today,
                UpdatedAt = today,
                CreatedBy = admin,
                UpdatedBy = admin
            }
            #endregion
            );
        }
    }
}

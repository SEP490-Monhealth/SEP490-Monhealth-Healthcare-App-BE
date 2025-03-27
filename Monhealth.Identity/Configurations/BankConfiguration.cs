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
                BankId = Guid.NewGuid(),
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
                BankId = Guid.NewGuid(),
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
                BankId = Guid.NewGuid(),
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
                BankId = Guid.NewGuid(),
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
                BankId = Guid.NewGuid(),
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
                BankId = Guid.NewGuid(),
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
                BankId = Guid.NewGuid(),
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

            #region Bank 8
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 9
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 10
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 11
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 12 
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 13
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 14
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 15
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 16
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 17
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 18
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 19
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 20
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 21
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 22
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 23
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 24
            new Bank
            {
                BankId = Guid.NewGuid(),
                BankCode = "",
                BankName = "",
                ShortName = "",
                LogoUrl = "https://",
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
                BankId = Guid.NewGuid(),
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
                BankId = Guid.NewGuid(),
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
                BankId = Guid.NewGuid(),
                BankCode = "",
                BankName = "",
                ShortName = "",
                LogoUrl = "https://",
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
                BankId = Guid.NewGuid(),
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

            #region Bank 29
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 30
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 31
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 32
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 33
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 34
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 35
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 36
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 37
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 38
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 39
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 40
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 41
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 42
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 43
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 44
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 45
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 46
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 47
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 48
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 49
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 50
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 51
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 52
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 53
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 54
            new Bank
            {
                BankId = Guid.NewGuid(),
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
                BankId = Guid.NewGuid(),
                BankCode = "CTG",
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

            #region Bank 56
            new Bank
            {
                BankId = Guid.NewGuid(),
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

            #region Bank 57
            new Bank
            {
                BankId = Guid.NewGuid(),
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

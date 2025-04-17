using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Identity.Models;

namespace Monhealth.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();

            var userId = Guid.Parse("3026595f-1414-4b74-be8f-11b7f6e7f4f6");
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            new AppUser
            {
                Id = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6"),
                FullName = "asd",
                Status = true,
                Email = "asd@gmail.com",
                NormalizedEmail = "ASD@GMAIL.COM",
                UserName = "asd",
                NormalizedUserName = "ASD",
                PhoneNumber = "0123456789",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Ftests%2Fangrycat.jpg?alt=media&token=542becf5-173f-47c2-951b-b9f79578fa60",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                UpdatedAt = today,
                CreatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                FullName = "Văn Hữu Toàn",
                Status = true,
                Email = "toanvan@gmail.com",
                NormalizedEmail = "TOANVAN@GMAIL.COM",
                UserName = "vipro123",
                NormalizedUserName = "VIPRO123",
                PhoneNumber = "0792766979",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F92077987-c716-4efc-b039-12268e8cb97d.jpg?alt=media&token=903adb9c-41c4-4482-a439-3c758b3c050d",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                UpdatedAt = today,
                CreatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87"),
                FullName = "Nguyễn Quốc Đại",
                Status = true,
                Email = "quocdai@gmail.com",
                NormalizedEmail = "QUOCDAI@GMAIL.COM",
                UserName = "dainq115",
                NormalizedUserName = "DAINQ115",
                PhoneNumber = "0932748924",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2Fef00731b-724a-4e80-8930-36b2abffbec6.jpg?alt=media&token=408e26ce-b249-4139-a919-5cac9082c35c",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                UpdatedAt = today,
                CreatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E"),
                FullName = "Phan Văn Khải",
                Status = true,
                Email = "khaitoi@gmail.com",
                NormalizedEmail = "KHAITOI@GMAIL.COM",
                UserName = "xautrai123",
                NormalizedUserName = "XAUTRAI123",
                PhoneNumber = "0963122758",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2Fcb927cfb-c88a-48c6-abf7-e77c9ca1982d.jpg?alt=media&token=e6cbb66c-6ecb-45ef-ac25-29511f9e7adb",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                UpdatedAt = today,
                CreatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                FullName = "Phạm Hoài Duy",
                Status = true,
                Email = "duythunglungtinhiu@gmail.com",
                NormalizedEmail = "DUYTHUNGLUNGTINHIU",
                UserName = "duypro113",
                NormalizedUserName = "DUYPRO113",
                PhoneNumber = "0967588443",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F467b63b9-c4c2-42c2-ba5a-71f294681586.jpg?alt=media&token=89eb5119-1669-4515-9dc6-9130672d3d50",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                UpdatedAt = today,
                CreatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2"),
                FullName = "Nguyễn Phạm Khanh",
                Status = true,
                Email = "khanhpham@gmail.com",
                NormalizedEmail = "KHANHPHAM@GMAIL.COM",
                UserName = "kuem113",
                NormalizedUserName = "KUEM113",
                PhoneNumber = "0368309526",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F9c0e576b-c736-4c13-8f21-aa0b1649fe5c.jpg?alt=media&token=236a11b7-836c-4735-b4c8-109a58b41e45",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                UpdatedAt = today,
                CreatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
                FullName = "Trần Nhật Quang",
                Status = true,
                Email = "quangdalat@gmail.com",
                NormalizedEmail = "QUANGDALAT@GMAIL.COM",
                UserName = "quangspa09",
                NormalizedUserName = "QUANGSPA009",
                PhoneNumber = "0999777712",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F16296811-d53d-4415-a907-e899e206b492.jpg?alt=media&token=819eaa35-ae0f-4dc3-815d-4dc19ab22782",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("6535e9eb-fd28-448a-bb0f-31b2dbe2a013"),
                FullName = "Phạm Đức Thịnh",
                Status = true,
                Email = "phamducthinh@gmail.com",
                NormalizedEmail = "PHAMDUCTHINH@GMAIL.COM",
                UserName = "thinhfa123",
                NormalizedUserName = "THINHFA123",
                PhoneNumber = "0961234567",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F470571730_1366066811024707_881271775933456916_n.jpg?alt=media&token=cddd2828-8693-44d8-98fa-98d8b9119656",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("258e6035-f606-492e-9d24-c6e27ec1ecfe"),
                FullName = "Nguyễn Quốc Duy",
                Status = true,
                Email = "nqduy@gmail.com",
                NormalizedEmail = "NQDUY@GMAIL.COM",
                UserName = "duynguyenquoc",
                NormalizedUserName = "DUYNGUYENQUOC",
                PhoneNumber = "0983607574",
                Avatar = "",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                UpdatedAt = DateTime.ParseExact("12-04-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("12-04-2025", "dd-MM-yyyy", null),
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("2606b7e4-3fec-43c2-8988-8db7dfb0d56e"),
                FullName = "Đinh Thế Anh",
                Status = true,
                Email = "anhthedinh@gmail.com",
                NormalizedEmail = "ANHTHEDINH@GMAIL.COM",
                UserName = "theanhdepzai",
                NormalizedUserName = "THEANHDEPZAI",
                PhoneNumber = "0906643433",
                Avatar = "",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                UpdatedAt = DateTime.ParseExact("12-04-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("12-04-2025", "dd-MM-yyyy", null),
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("b49c65e4-1864-4f8d-82ad-87838284e33f"),
                FullName = "Trần Xuân Quang",
                Status = true,
                Email = "quangfuhola@gmail.com",
                NormalizedEmail = "QUANGFUHOLA@GMAIL.COM",
                UserName = "qaqfuhola",
                NormalizedUserName = "QAQFUHOLA",
                PhoneNumber = "0951237521",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F469647230_2079099535874281_3037480323183292732_n.jpg?alt=media&token=fb87f351-8ba2-4987-8ce1-d23704a3625f",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                UpdatedAt = DateTime.ParseExact("10-04-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("10-04-2025", "dd-MM-yyyy", null),
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("619de5dc-80d1-40c7-bae5-bd8940d6e780"),
                FullName = "Nguyễn Tiến Phát",
                Status = true,
                Email = "nguyenphat@gmail.com",
                NormalizedEmail = "NGUYENPHAT@GMAIL.COM",
                UserName = "phatbe114",
                NormalizedUserName = "PHATBE114",
                PhoneNumber = "0961434567",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F476503216_635093698997337_8270148483946389400_n.jpg?alt=media&token=3a6b111c-bda3-4f70-9273-1144c7b4910c",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                UpdatedAt = DateTime.ParseExact("01-05-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("01-05-2025", "dd-MM-yyyy", null),
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("b2ad99a0-43fd-4b12-8864-3a2e2626fb90"),
                FullName = "Nguyễn Văn Dũng",
                Status = true,
                Email = "nguyenvandung@gmail.com",
                NormalizedEmail = "NGUYENVANDUNG@GMAIL.COM",
                UserName = "dungfe113",
                NormalizedUserName = "DUNGFE113",
                PhoneNumber = "0961233264",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F116903299_1425092281017219_6440424626013075423_n.jpg?alt=media&token=119a783e-4a9d-4d1c-a427-115df697f1ca",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                UpdatedAt = DateTime.ParseExact("01-05-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("01-05-2025", "dd-MM-yyyy", null),
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("06114384-3057-49ea-b106-e03c0e0e8f20"),
                FullName = "Văn Hữu Toàn",
                Status = true,
                Email = "vanhuutoan27@gmail.com",
                NormalizedEmail = "VANHUUTOAN27@GMAIL.COM",
                UserName = "toandevtrai",
                NormalizedUserName = "TOANDEVTRAI",
                PhoneNumber = "",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2Fz6092344870918_1ddc20ef2ae3cb256497bcfae9abc600.jpg?alt=media&token=fb76c360-aaea-428e-b0b2-73bd22714098",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                UpdatedAt = DateTime.ParseExact("20-04-2025", "dd-MM-yyyy", null),
                CreatedAt = DateTime.ParseExact("20-04-2025", "dd-MM-yyyy", null),
                CreatedBy = userId,
                UpdatedBy = userId,
            }

            // new AppUser
            // {
            //     Id = Guid.Parse("20041d5b-01e4-443f-9652-e39beb9748e5"),
            //     FullName = "Van Huu Toan Con",
            //     Status = true,
            //     Email = "consultant@gmail.com",
            //     NormalizedEmail = "CONSULTANT@GMAIL.COM",
            //     UserName = "toanconsultant",
            //     NormalizedUserName = "0987654321",
            //     PhoneNumber = "0987654321",
            //     Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth%2Fusers%2F92077987-c716-4efc-b039-12268e8cb97d.jpg?alt=media&token=903adb9c-41c4-4482-a439-3c758b3c050d",
            //     LockoutEnabled = false,
            //     EmailConfirmed = true,
            //     PasswordHash = hasher.HashPassword(null, "123As@"),
            //     SecurityStamp = Guid.NewGuid().ToString(),
            //     UpdatedAt = today,
            //     CreatedAt = today,
            //     CreatedBy = userId,
            //     UpdatedBy = userId,
            // }
            );
        }
    }
}

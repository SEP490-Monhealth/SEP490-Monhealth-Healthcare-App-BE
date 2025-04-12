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
                FullName = "Van Huu Toan",
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
                FullName = "Nguyen Quoc Dai",
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
                FullName = "Phan Van Khai",
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
                FullName = "Pham Hoai Duy",
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
                FullName = "Nguyen Pham Khanh",
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
                FullName = "Quang La Tui",
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
                UpdatedAt = today,
                CreatedAt = today,
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("20041d5b-01e4-443f-9652-e39beb9748e5"),
                FullName = "Van Huu Toan Con",
                Status = true,
                Email = "consultant@gmail.com",
                NormalizedEmail = "CONSULTANT@GMAIL.COM",
                UserName = "toanconsultant",
                NormalizedUserName = "0987654321",
                PhoneNumber = "0987654321",
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
                Id = Guid.Parse("bf1c4dc8-8b1a-4bcd-9bf3-5a4d4b27eace"),
                FullName = "Nguyễn Văn An",
                Status = true,
                Email = "annguyen@gmail.com",
                NormalizedEmail = "ANNGUYEN@GMAIL.COM",
                UserName = "AnNguyen",
                NormalizedUserName = "0912345678", // Hoặc có thể dùng tên đăng nhập khác
                PhoneNumber = "0912345678",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth/users/user1.jpg?alt=media",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                CreatedAt = new DateTime(2024, 11, 10, 10, 30, 0),
                UpdatedAt = new DateTime(2024, 11, 10, 10, 30, 0),
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("3de3c3b2-a9f6-4b7a-80e8-cd9453a32a96"),
                FullName = "Trần Thị Bình",
                Status = true,
                Email = "binhtran@gmail.com",
                NormalizedEmail = "BINHTRAN@GMAIL.COM",
                UserName = "BinhTran",
                NormalizedUserName = "0923456789",
                PhoneNumber = "0923456789",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth/users/user2.jpg?alt=media",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                CreatedAt = new DateTime(2024, 12, 15, 11, 0, 0),
                UpdatedAt = new DateTime(2024, 12, 15, 11, 0, 0),
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("6f3bd8a1-7c29-4b2c-8ef1-107aa055c2b2"),
                FullName = "Lê Minh Châu",
                Status = true,
                Email = "chaule@gmail.com",
                NormalizedEmail = "CHAULE@GMAIL.COM",
                UserName = "ChauLe",
                NormalizedUserName = "0934567890",
                PhoneNumber = "0934567890",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth/users/user3.jpg?alt=media",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                // User này được tạo lúc 10/01/2025
                CreatedAt = new DateTime(2025, 1, 10, 9, 45, 0),
                UpdatedAt = new DateTime(2025, 1, 10, 9, 45, 0),
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("d8a12345-67b8-4c3d-9e0f-1ab2cd3ef456"),
                FullName = "Phạm Văn Dũng",
                Status = true,
                Email = "dungpham@gmail.com",
                NormalizedEmail = "DUNGPHAM@GMAIL.COM",
                UserName = "DungPham",
                NormalizedUserName = "0945678901",
                PhoneNumber = "0945678901",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth/users/user4.jpg?alt=media",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                // User này được tạo lúc 10/02/2025
                CreatedAt = new DateTime(2025, 2, 10, 10, 15, 0),
                UpdatedAt = new DateTime(2025, 2, 10, 10, 15, 0),
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("e7c2b9c3-df34-4f78-9c8a-0fab1b2c3d4e"),
                FullName = "Đỗ Thị Hồng",
                Status = true,
                Email = "hongdo@gmail.com",
                NormalizedEmail = "HONGDO@GMAIL.COM",
                UserName = "HongDo",
                NormalizedUserName = "0956789012",
                PhoneNumber = "0956789012",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth/users/user5.jpg?alt=media",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                // User này được tạo lúc 10/03/2025
                CreatedAt = new DateTime(2025, 3, 10, 14, 30, 0),
                UpdatedAt = new DateTime(2025, 3, 10, 14, 30, 0),
                CreatedBy = userId,
                UpdatedBy = userId,
            },

            new AppUser
            {
                Id = Guid.Parse("35efcfae-e3ff-477f-af62-74b0764fbf5b"),
                FullName = "Hoàng Quốc Huy",
                Status = true,
                Email = "huyhoang@gmail.com",
                NormalizedEmail = "HUYHOANG@GMAIL.COM",
                UserName = "HuyHoang",
                NormalizedUserName = "0967890123",
                PhoneNumber = "0967890123",
                Avatar = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/Monhealth/users/user6.jpg?alt=media",
                LockoutEnabled = false,
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "123As@"),
                SecurityStamp = Guid.NewGuid().ToString(),
                // User này được tạo lúc 10/04/2025
                CreatedAt = new DateTime(2025, 4, 10, 16, 0, 0),
                UpdatedAt = new DateTime(2025, 4, 10, 16, 0, 0),
                CreatedBy = userId,
                UpdatedBy = userId,
            }
            );
        }
    }
}

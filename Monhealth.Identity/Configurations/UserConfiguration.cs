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

            builder.HasData(
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
                    LockoutEnabled = false,
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123As@"),
                    SecurityStamp = Guid.NewGuid().ToString(),

                    UpdatedAt = DateTime.Parse("2025-01-06"),
                    CreatedAt = DateTime.Parse("2025-01-06"),
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
                     LockoutEnabled = false,
                     EmailConfirmed = true,
                     PasswordHash = hasher.HashPassword(null, "123As@"),
                     SecurityStamp = Guid.NewGuid().ToString(),

                     UpdatedAt = DateTime.Parse("2025-01-06"),
                     CreatedAt = DateTime.Parse("2025-01-06"),
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
                      PhoneNumber = "0969998878",
                      LockoutEnabled = false,
                      EmailConfirmed = true,
                      PasswordHash = hasher.HashPassword(null, "123As@"),
                      SecurityStamp = Guid.NewGuid().ToString(),

                      UpdatedAt = DateTime.Parse("2025-01-06"),
                      CreatedAt = DateTime.Parse("2025-01-06"),
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
                       LockoutEnabled = false,
                       EmailConfirmed = true,
                       PasswordHash = hasher.HashPassword(null, "123As@"),
                       SecurityStamp = Guid.NewGuid().ToString(),

                       UpdatedAt = DateTime.Parse("2025-01-06"),
                       CreatedAt = DateTime.Parse("2025-01-06"),
                   },
                    new AppUser
                    {
                        Id = Guid.Parse("4565F47A-7239-4666-B9B4-0523B1D9BA3D"),
                        FullName = "Quang La Tui",
                        Status = true,
                        Email = "quangdalat@gmail.com",
                        NormalizedEmail = "QUANGDALAT@GMAIL.COM",
                        UserName = "quangspa09",
                        NormalizedUserName = "QUANGSPA009",
                        PhoneNumber = "0999777712",
                        LockoutEnabled = false,
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "123As@"),
                        SecurityStamp = Guid.NewGuid().ToString(),

                        UpdatedAt = DateTime.Parse("2025-01-06"),
                        CreatedAt = DateTime.Parse("2025-01-06"),
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
                        PhoneNumber = "0555666612",
                        LockoutEnabled = false,
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "123As@"),
                        SecurityStamp = Guid.NewGuid().ToString(),

                        UpdatedAt = DateTime.Parse("2025-01-06"),
                        CreatedAt = DateTime.Parse("2025-01-06"),
                    }
                );
        }
    }
}

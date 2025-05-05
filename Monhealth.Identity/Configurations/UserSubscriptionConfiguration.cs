using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Core.Enum;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class UserSubscriptionConfiguration : IEntityTypeConfiguration<UserSubscription>
    {
        public void Configure(EntityTypeBuilder<UserSubscription> builder)
        {
            builder.HasData(

            // Toàn
            #region Gói cơ bản
            new UserSubscription
            {
                UserSubscriptionId = Guid.NewGuid(),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                SubscriptionId = Guid.Parse("9DBA3BB9-D153-4490-B39E-7C889CF01759"),
                StartedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                ExpiresAt = DateTime.ParseExact("01-05-2025", "dd-MM-yyyy", null),
                RemainingBookings = 0,
                Status = UserSubscriptionStatus.Expired,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null)
            },
            #endregion

            #region Gói cao cấp
            new UserSubscription
            {
                UserSubscriptionId = Guid.Parse("539F85A5-E937-4DE4-C57A-08DD887F2CD1"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                SubscriptionId = Guid.Parse("51789ABD-BBCC-42EF-9663-F2EA104302BD"),
                StartedAt = DateTime.ParseExact("02-05-2025", "dd-MM-yyyy", null),
                ExpiresAt = DateTime.ParseExact("02-06-2025", "dd-MM-yyyy", null),
                RemainingBookings = 3,
                Status = UserSubscriptionStatus.Active,
                CreatedAt = DateTime.ParseExact("02-05-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("02-05-2025", "dd-MM-yyyy", null)
            },
            #endregion

            // Đại
            #region Gói cơ bản
            new UserSubscription
            {
                UserSubscriptionId = Guid.NewGuid(),
                UserId = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87"),
                SubscriptionId = Guid.Parse("9DBA3BB9-D153-4490-B39E-7C889CF01759"),
                StartedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                ExpiresAt = DateTime.ParseExact("01-05-2035", "dd-MM-yyyy", null),
                RemainingBookings = 0,
                Status = UserSubscriptionStatus.Active,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null)
            },
            #endregion

            // Khải
            #region Gói cơ bản
            new UserSubscription
            {
                UserSubscriptionId = Guid.NewGuid(),
                UserId = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E"),
                SubscriptionId = Guid.Parse("9DBA3BB9-D153-4490-B39E-7C889CF01759"),
                StartedAt = DateTime.ParseExact("02-05-2025", "dd-MM-yyyy", null),
                ExpiresAt = DateTime.ParseExact("02-05-2025", "dd-MM-yyyy", null),
                RemainingBookings = 0,
                Status = UserSubscriptionStatus.Active,
                CreatedAt = DateTime.ParseExact("01-03-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-03-2025", "dd-MM-yyyy", null)
            },
            #endregion

            #region Gói cao cấp
            new UserSubscription
            {
                UserSubscriptionId = Guid.Parse("3978e53f-53e8-4650-9089-6e417858c27f"),
                UserId = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E"),
                SubscriptionId = Guid.Parse("51789ABD-BBCC-42EF-9663-F2EA104302BD"),
                StartedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
                ExpiresAt = DateTime.ParseExact("03-06-2025", "dd-MM-yyyy", null),
                RemainingBookings = 3,
                Status = UserSubscriptionStatus.Active,
                CreatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null)
            },
            #endregion


            // Duy
            #region Gói cơ bản
            new UserSubscription
            {
                UserSubscriptionId = Guid.NewGuid(),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                SubscriptionId = Guid.Parse("9DBA3BB9-D153-4490-B39E-7C889CF01759"),
                StartedAt = DateTime.ParseExact("03-04-2025", "dd-MM-yyyy", null),
                ExpiresAt = DateTime.ParseExact("03-05-2025", "dd-MM-yyyy", null),
                RemainingBookings = 0,
                Status = UserSubscriptionStatus.Expired,
                CreatedAt = DateTime.ParseExact("02-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("02-04-2025", "dd-MM-yyyy", null)
            },
            #endregion

            #region Gói nâng cao
            new UserSubscription
            {
                UserSubscriptionId = Guid.Parse("2ca216a2-6c36-480b-a312-5f1d8076dfcc"),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                SubscriptionId = Guid.Parse("e62b480d-16a6-4565-87fa-262870d75f68"),
                StartedAt = DateTime.ParseExact("04-05-2025", "dd-MM-yyyy", null),
                ExpiresAt = DateTime.ParseExact("04-06-2025", "dd-MM-yyyy", null),
                RemainingBookings = 3,
                Status = UserSubscriptionStatus.Active,
                CreatedAt = DateTime.ParseExact("04-05-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("04-05-2025", "dd-MM-yyyy", null)
            },
            #endregion

            // Khanh
            #region Gói cơ bản
            new UserSubscription
            {
                UserSubscriptionId = Guid.NewGuid(),
                UserId = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2"),
                SubscriptionId = Guid.Parse("9DBA3BB9-D153-4490-B39E-7C889CF01759"),
                StartedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                ExpiresAt = DateTime.ParseExact("01-05-2035", "dd-MM-yyyy", null),
                RemainingBookings = 0,
                Status = UserSubscriptionStatus.Active,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null)
            }
            #endregion

            );
        }
    }
}
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

            #region User UserSubscription 1
            new UserSubscription
            {
                UserSubscriptionId = Guid.NewGuid(),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                SubscriptionId = Guid.Parse("9DBA3BB9-D153-4490-B39E-7C889CF01759"),
                StartedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                ExpiresAt = DateTime.ParseExact("01-05-2125", "dd-MM-yyyy", null),
                RemainingBookings = 0,
                Status = UserSubscriptionStatus.Expired,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null)
            },
            #endregion

            #region User UserSubscription 2
            new UserSubscription
            {
                UserSubscriptionId = Guid.Parse("539F85A5-E937-4DE4-C57A-08DD887F2CD1"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B"),
                SubscriptionId = Guid.Parse("51789ABD-BBCC-42EF-9663-F2EA104302BD"),
                StartedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                ExpiresAt = DateTime.ParseExact("01-05-2025", "dd-MM-yyyy", null),
                RemainingBookings = 3,
                Status = UserSubscriptionStatus.Active,
                CreatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null),
                UpdatedAt = DateTime.ParseExact("01-04-2025", "dd-MM-yyyy", null)
            }
            #endregion
            );
        }
    }
}
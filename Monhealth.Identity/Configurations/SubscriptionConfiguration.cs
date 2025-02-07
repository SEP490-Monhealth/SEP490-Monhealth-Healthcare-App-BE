using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
    {
        public void Configure(EntityTypeBuilder<Subscription> builder)
        {
            var today = DateTime.ParseExact("06-01-2025", "dd-MM-yyyy", null);

            builder.HasData(

            #region Subscription 1
            new Subscription
            {
                SubscriptionId = Guid.Parse("af1d42fa-b5d2-469e-918b-724d8db19009"),
                SubscriptionName = "Gói cơ bản (Basic)",
                Price = 0,
                CreatedAt = today,
                UpdatedAt = today
            },
            #endregion

            #region Subscription 2
            new Subscription
            {
                SubscriptionId = Guid.Parse("b743cc4e-cb7d-4f94-bc91-a2631d4506fa"),
                SubscriptionName = "Gói cao cấp (Premium)",
                Price = 99000,
                CreatedAt = today,
                UpdatedAt = today
            }
            #endregion
            );
        }
    }
}
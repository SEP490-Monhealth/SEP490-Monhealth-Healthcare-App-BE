// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Metadata.Builders;
// using Monhealth.Core.Enum;
// using Monhealth.Domain;

// namespace Monhealth.Identity.Configurations
// {
//     public class UserSubscriptionConfiguration : IEntityTypeConfiguration<UserSubscription>
//     {
//         public void Configure(EntityTypeBuilder<UserSubscription> builder)
//         {
//             builder.HasData(

//             #region User UserSubscription 1
//             new UserSubscription
//             {
//                 UserSubscriptionId = Guid.Parse("7552390b-5fc0-47c1-a103-6539e190619a"),
//                 UserId = Guid.Parse("06114384-3057-49ea-b106-e03c0e0e8f20"),
//                 SubscriptionId = Guid.Parse("51789ABD-BBCC-42EF-9663-F2EA104302BD"),
//                 StartedAt = DateTime.ParseExact("24-04-2025", "dd-MM-yyyy", null),
//                 ExpiresAt = DateTime.ParseExact("24-05-2025", "dd-MM-yyyy", null),
//                 RemainingBookings = 3,
//                 Status = UserSubscriptionStatus.Active,
//                 CreatedAt = DateTime.ParseExact("24-04-2025", "dd-MM-yyyy", null),
//                 UpdatedAt = DateTime.ParseExact("24-04-2025", "dd-MM-yyyy", null)
//             }
//             #endregion
//             );
//         }
//     }
// }
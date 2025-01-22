using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Core;

namespace Monhealth.Identity.Configurations
{
    public class FoodAllergyConfiguration : IEntityTypeConfiguration<FoodAllergy>
    {
        public void Configure(EntityTypeBuilder<FoodAllergy> builder)
        {
            builder.HasData(

            #region FoodAllergy 1
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("12536007-f0ee-4103-ac40-596416fbb64c"),
                FoodId = Guid.Parse("08b5c5da-4b0c-48f3-98fc-33420bdf8163"),
                AllergyId = Guid.Parse("16acfb07-feee-4bb9-ad2b-05e5b93d18e6")
            },
            #endregion

            #region FoodAllergy 2
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("32bc349f-caa3-4f23-90d1-15e174b56dae"),
                FoodId = Guid.Parse("08b5c5da-4b0c-48f3-98fc-33420bdf8163"),
                AllergyId = Guid.Parse("10127b02-786f-462b-8ee6-3df465903645")
            },
            #endregion

            #region FoodAllergy 3
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("575bf09f-9d81-4931-a987-de015da6b6fa"),
                FoodId = Guid.Parse("c42e7f00-ea31-430a-ac28-8d6e749b7eca"),
                AllergyId = Guid.Parse("70fef89b-5b02-4d6c-81e0-40592eefcb2a")
            },
            #endregion

            #region FoodAllergy 4
            new FoodAllergy
            {
                FoodAllergyId = Guid.Parse("83143049-d2ba-4a1c-939c-ccba2cc7dec4"),
                FoodId = Guid.Parse("021b651c-bb01-4965-95bc-3532fbacad3d"),
                AllergyId = Guid.Parse("d0127ea2-7f55-4515-b5ea-3db55af5774e")
            }
            #endregion
            );
        }
    }
}
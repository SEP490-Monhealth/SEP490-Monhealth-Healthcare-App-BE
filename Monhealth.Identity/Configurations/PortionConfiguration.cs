using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;

namespace Monhealth.Identity.Configurations
{
    public class PortionConfiguration : IEntityTypeConfiguration<Portion>
    {
        public void Configure(EntityTypeBuilder<Portion> builder)
        {
            builder.HasData(
                new Portion
                {
                    PortionId = Guid.Parse("d2f3a6c9-19c1-45fa-9a4f-3ad8396c19a7"),
                    PortionSize = "Phần ăn",
                    PortionWeight = 100,
                    MeasurementUnit = "g"
                },
                new Portion
                {
                    PortionId = Guid.Parse("a44fd2e0-b595-4423-9e6f-42a010d96f66"),
                    PortionSize = "Chén",
                    PortionWeight = 100,
                    MeasurementUnit = "g"
                }
            );
        }
    }
}

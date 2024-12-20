using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    PortionId = Guid.Parse("d2f3a6c9-19c1-45fa-9a4f-3ad8396c19a7"),
                    PortionSize = "Chén",
                    PortionWeight = 100,
                    MeasurementUnit = "g"
                }
            );
        }
    }
}

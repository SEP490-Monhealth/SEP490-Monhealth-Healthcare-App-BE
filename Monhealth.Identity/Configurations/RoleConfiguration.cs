using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monhealth.Identity.Models;

namespace Monhealth.Identity.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(
                        new AppRole
                        {
                            Id = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC"),
                            Name = "Customer",
                            NormalizedName = "CUSTOMER",
                            DisplayName = "Khách Hàng"
                        },
                        new AppRole
                        {
                            Id = Guid.Parse("C0278115-8549-4FAD-890A-44F8E8FCC022"),
                            Name = "Manager",
                            NormalizedName = "MANAGER",
                            DisplayName = "Quản Lí"
                        }


                      );
        }
    }
}

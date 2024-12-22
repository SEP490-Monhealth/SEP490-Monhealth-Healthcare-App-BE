using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Monhealth.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(
                        new IdentityUserRole<Guid>
                        {
                            RoleId = Guid.Parse("C0278115-8549-4FAD-890A-44F8E8FCC022"),
                            UserId = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87")
                        },
                        new IdentityUserRole<Guid>
                        {
                            RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC"),
                            UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B")
                        },
                        new IdentityUserRole<Guid>
                        {
                            RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC"),
                            UserId = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2")
                        },
                        new IdentityUserRole<Guid>
                        {
                            RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC"),
                            UserId = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E")
                        },
                         new IdentityUserRole<Guid>
                         {
                             RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC"),
                             UserId = Guid.Parse("4565F47A-7239-4666-B9B4-0523B1D9BA3D"),
                         },
                         new IdentityUserRole<Guid>
                         {
                             RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC"),
                             UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
                         }


                        );
        }
    }
}

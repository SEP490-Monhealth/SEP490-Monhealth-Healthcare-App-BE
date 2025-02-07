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
                Id = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                Name = "User",
                NormalizedName = "USER",
                DisplayName = "Người dùng"
            },
            new AppRole
            {
                Id = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC"),
                Name = "Member",
                NormalizedName = "MEMBER",
                DisplayName = "Thành viên"
            },
            new AppRole
            {
                Id = Guid.Parse("C0278115-8549-4FAD-890A-44F8E8FCC022"),
                Name = "Consultant",
                NormalizedName = "CONSULTANT",
                DisplayName = "Tư vấn viên"
            },
            new AppRole
            {
                Id = Guid.Parse("1975eaae-fd39-417e-bfcc-5e09f963b95f"),
                Name = "Manager",
                NormalizedName = "MANAGER",
                DisplayName = "Quản lý"
            },
            new AppRole
            {
                Id = Guid.Parse("D21EDFD6-42D5-490A-A41C-43F7EF09C61F"),
                Name = "Admin",
                NormalizedName = "ADMIN",
                DisplayName = "Quản trị viên"
            });
        }
    }
}

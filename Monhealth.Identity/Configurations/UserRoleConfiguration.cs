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

            // asd admin    
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("D21EDFD6-42D5-490A-A41C-43F7EF09C61F"),
                UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6")
            },

            // van huu toan member
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B")
            },

            // nguyen quoc dai member
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                UserId = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87")
            },

            // phan van khai member
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                UserId = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E")
            },

            // pham hoai duy member
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
            },

            // nguyen pham khanh member
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                UserId = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2")
            },

            // tran nhat quang consultant
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("c0278115-8549-4fad-890a-44f8E8fcc022"),
                UserId = Guid.Parse("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
            },

            // pham duc thinh consultant
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("c0278115-8549-4fad-890a-44f8E8fcc022"),
                UserId = Guid.Parse("6535e9eb-fd28-448a-bb0f-31b2dbe2a013"),
            },

            // nguyen quoc duy consultant
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("c0278115-8549-4fad-890a-44f8E8fcc022"),
                UserId = Guid.Parse("258e6035-f606-492e-9d24-c6e27ec1ecfe"),
            },

            // dinh the anh consultant
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("c0278115-8549-4fad-890a-44f8E8fcc022"),
                UserId = Guid.Parse("2606b7e4-3fec-43c2-8988-8db7dfb0d56e"),
            },

            // tran xuan quang consultant
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("c0278115-8549-4fad-890a-44f8E8fcc022"),
                UserId = Guid.Parse("b49c65e4-1864-4f8d-82ad-87838284e33f"),
            },

            // nguyen tien phat consultant
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("c0278115-8549-4fad-890a-44f8E8fcc022"),
                UserId = Guid.Parse("619de5dc-80d1-40c7-bae5-bd8940d6e780"),
            },

            // nguyen van dung consultant
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("c0278115-8549-4fad-890a-44f8E8fcc022"),
                UserId = Guid.Parse("b2ad99a0-43fd-4b12-8864-3a2e2626fb90"),
            },

            // van huu toan subscription member
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC"),
                UserId = Guid.Parse("06114384-3057-49ea-b106-e03c0e0e8f20"),
            }

            // van huu toan con consultant
            // new IdentityUserRole<Guid>
            // {
            //     RoleId = Guid.Parse("c0278115-8549-4fad-890a-44f8E8fcc022"),
            //     UserId = Guid.Parse("20041d5b-01e4-443f-9652-e39beb9748e5")
            // }
            );
        }
    }
}

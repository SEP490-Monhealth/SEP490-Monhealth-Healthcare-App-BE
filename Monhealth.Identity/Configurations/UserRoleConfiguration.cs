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

            // nguyen quoc dai member
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                UserId = Guid.Parse("277EA066-D041-40FF-9DAE-6271DBD6FD87")
            },

            // van huu toan member
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                UserId = Guid.Parse("9D7E87A9-B070-4607-A0B0-2D2322AECE9B")
            },

            //nguyen pham khanh member
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                UserId = Guid.Parse("0075BA2C-F60D-4F75-B9F1-F71579BC4FD2")
            },

            //phan van khai member
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                UserId = Guid.Parse("3B1A8845-765F-4D91-984A-4E8A9D7D376E")
            },

            // tran nhat quang member
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                UserId = Guid.Parse("4565f47a-7239-4666-b9b4-0523b1d9ba3d"),
            },

            //pham hoai duy member
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                UserId = Guid.Parse("1246B8E5-AF73-4AA3-BDEF-B8815E21A78B"),
            },

            // asd admin    
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("D21EDFD6-42D5-490A-A41C-43F7EF09C61F"),
                UserId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6")
            },

            //van huu toan con consultant
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("c0278115-8549-4fad-890a-44f8E8fcc022"),
                UserId = Guid.Parse("20041d5b-01e4-443f-9652-e39beb9748e5")
            },

           //Nguyen VAn An Member
           new IdentityUserRole<Guid>
           {
               RoleId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
               UserId = Guid.Parse("bf1c4dc8-8b1a-4bcd-9bf3-5a4d4b27eace"),
           },
           //Tran Thi Binh Member
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                UserId = Guid.Parse("3de3c3b2-a9f6-4b7a-80e8-cd9453a32a96"),
            },
            //Le Minh Chau Member
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                UserId = Guid.Parse("6f3bd8a1-7c29-4b2c-8ef1-107aa055c2b2"),
            },
            //Pham Van Dung Member
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                UserId = Guid.Parse("d8a12345-67b8-4c3d-9e0f-1ab2cd3ef456"),
            },
            //Do Thi Hong Member
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                UserId = Guid.Parse("e7c2b9c3-df34-4f78-9c8a-0fab1b2c3d4e"),
            },
            //Hoang Quoc Huy Member
            new IdentityUserRole<Guid>
            {
                RoleId = Guid.Parse("3F2504E0-4F89-11D3-9A0C-0305E82C3301"),
                UserId = Guid.Parse("35efcfae-e3ff-477f-af62-74b0764fbf5b"),
            }

            );
        }
    }
}

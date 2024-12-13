using Microsoft.AspNetCore.Identity;
using Monhealth.Identity.Models;

namespace Monhealth.Identity.Dbcontexts
{
    public class DataSeeder
    {
        public async Task SeedAsync(MonhealthDbcontext context)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            var rootAdminRoleId = Guid.Parse("D21EDFD6-42D5-490A-A41C-43F7EF09C61F");

            if (!context.Roles.Any(r => r.Name.Equals("Admin")))
            {
                await context.Roles.AddAsync(new AppRole()
                {
                    Id = rootAdminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    DisplayName = "Quản trị viên"
                });
                await context.SaveChangesAsync();

                //add user
                var userId = Guid.Parse("3026595F-1414-4B74-BE8F-11B7F6E7F4F6");
                var user = new AppUser()
                {
                    Id = userId,
                    FullName = "asd",
                    Email = "asd@gmail.com",
                    NormalizedEmail = "ASD@GMAIL.COM",
                    UserName = "asd",
                    NormalizedUserName = "ASD",
                    Address = "Cu Chi",
                    Status = true,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    LockoutEnabled = false,
                    CreatedAt = DateTime.Parse("2024-7-27"),
                    UpdatedAt = DateTime.Parse("2024-7-27"),
                    EmailConfirmed = true,
                };
                user.PasswordHash = passwordHasher.HashPassword(user, "123As@");
                await context.Users.AddAsync(user);

                await context.UserRoles.AddAsync(new IdentityUserRole<Guid>()
                {
                    RoleId = rootAdminRoleId,
                    UserId = userId,
                });
                await context.SaveChangesAsync();
            }



        }
    }
}

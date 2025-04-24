using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Monhealth.Identity.Dbcontexts;

namespace Monhealth.Identity
{
    public static class MigrationManager
    {
        public static WebApplication MigrationDatabase(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                using (var context = scope.ServiceProvider.GetRequiredService<MonhealthDbcontext>())
                {
                    context.Database.EnsureCreated();
                    if (!context.Users.Any())
                        new DataSeeder().SeedAsync(context).Wait();
                }
            }
            return app;
        }
    }
}

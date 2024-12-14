using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Identity;
using Monhealth.Identity.Dbcontexts;
using Monhealth.Identity.Models;
using Monhealth.Identity.Repositories;

namespace Monhealth.Identity
{
    public static class IdentityServicesRegistration
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MonhealthDbcontext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString")));

            services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<MonhealthDbcontext>().AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.   
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = false;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = false;
            });
            services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            services.AddScoped<IMetricRepository, MetricRepository>();

            services.Configure<JwtTokenSettings>(configuration.GetSection(nameof(JwtTokenSettings)));

            return services;
        }

    }
}

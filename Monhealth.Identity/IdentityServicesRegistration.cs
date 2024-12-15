using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Monhealth.Application.Contracts.Persistence;
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

            services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            services.AddScoped<IMetricRepository, MetricRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            return services;
        }

    }
}

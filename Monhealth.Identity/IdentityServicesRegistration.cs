using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Monhealth.Application.Contracts.Identity;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Identity;
using Monhealth.Identity.Dbcontexts;
using Monhealth.Identity.Models;
using Monhealth.Identity.Repositories;
using Monhealth.Identity.Services;
using System.Text;

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

            services.AddScoped<SignInManager<AppUser>, SignInManager<AppUser>>();
            services.AddScoped<UserManager<AppUser>, UserManager<AppUser>>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<RoleManager<AppRole>, RoleManager<AppRole>>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPortionRepository, PortionRepository>();
            services.AddScoped<IFoodRepository, FoodRepository>();
            services.AddScoped<IFoodPortionRepository, FoodPortionRepository>();
            services.AddScoped<IMealRepository, MealRepository>();
            services.AddScoped<IMealFoodRepository, MealFoodRepository>();
            services.AddScoped<IDailyMealRepository, DailyMealRepository>();
            services.AddScoped<IReminderRepository, ReminderRepository>();
            // Add Authentication
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
           .AddJwtBearer(cfg =>
           {
               cfg.RequireHttpsMetadata = true;
               cfg.SaveToken = true;
               cfg.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateLifetime = true,
                   ClockSkew = TimeSpan.FromSeconds(0),
                   ValidIssuer = configuration["JwtTokenSettings:Issuer"],
                   ValidAudience = configuration["JwtTokenSettings:Issuer"],
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtTokenSettings:Key"]))
               };
           });



            // Other service configurations...
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<INutritionRepository, NutritionRepository>();
            return services;
        }

    }
}

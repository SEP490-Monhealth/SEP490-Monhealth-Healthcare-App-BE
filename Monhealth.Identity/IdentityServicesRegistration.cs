using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Monhealth.Application;
using Monhealth.Application.Contracts.Identity;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Contracts.Services;
using Monhealth.Application.Features.Metric.Commands.UpdateMetric;
using Monhealth.Application.Features.Subscription.UserSubscriptionBackgroundService;
using Monhealth.Application.Models.Identity;
using Monhealth.Identity.BackGroundServiceForWaterReminder;
using Monhealth.Identity.Dbcontexts;
using Monhealth.Identity.Models;
using Monhealth.Identity.Repositories;
using Monhealth.Identity.Services;
using Monteith.Application.Contracts.Persistence;
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
            services.AddScoped<IWaterReminderRepository, ReminderRepository>();
            services.AddScoped<IMetricsCalculator, MetricsCalculator>();
            services.AddScoped<IGoalRepository, GoalRepository>();
            services.AddScoped<IGoalsCalculator, GoalsCalculator>();
            services.AddScoped<IAllergyRepository, AllergyRepository>();
            services.AddScoped<ISubscriptionRepository, SubscriptionRepository>();
            services.AddScoped<IUserSubscriptionRepository, UserSubscriptionRepository>();
            services.AddScoped<IExerciseRepository, ExerciseRepository>();
            services.AddHostedService<ResetIsDrunkService>();
            services.AddScoped<IWorkoutRepository, WorkoutRepository>();
            services.AddScoped<IWorkoutExcerciseRepository, WorkoutExcerciseRepository>();
            services.AddScoped<ICertificateRepository, CertificateRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IExpertiseRepository, ExpertiseRepository>();
            services.AddScoped<IConsultantRepository, ConsultantRepository>();
            services.AddScoped<ICertificateRepository, CertificateRepository>();
            services.AddScoped<IWalletRepository, WalletRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IBankRepository, BankRepository>();
            services.AddScoped<IConsultantBankRepository, ConsultantBankRepository>();
            // Đăng ký MediatR
            services.AddScoped<WaterReminderResetService>();
            services.AddScoped<IDailyWaterIntakesRepository, DailyWaterIntakesRepository>();
            services.AddScoped<IScheduleRepository, ScheduleRepository>();
            services.AddScoped<IAllergyRepository, AllergyRepository>();
            services.AddScoped<IFoodAllergyRepository, FoodAllergyRepository>();
            services.AddScoped<IUserAllergyRepository, UserAllergyRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IActivityRepository, ActivityRepository>();
            services.AddScoped<IDailyActivityRepository, DailyActivityRepository>();
            services.AddScoped<ICategoryFoodRepository, CategoryFoodRepository>();
            services.AddScoped<IUserCategoryRepository, UserCategoryRepository>();
            services.AddScoped<IDishTypeFoodRepository, DishtypeFoodRepository>();
            services.AddScoped<IWithdrawalRepository, WithdrawalRepository>();
            services.AddScoped<ITimeSlotRepository, TimeSlotRepository>();
            services.AddScoped<IScheduleTimeSlotRepository, ScheduleTimeSlotRepository>();
            services.AddScoped<IScheduleExceptionRepository, ScheduleExceptionRepository>();
            services.AddScoped<IDishTypeRepository, DishTypeRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
            services.AddScoped<IChatRepository, ChatRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();
            services.AddScoped<IUserNotificationRepository, UserNotificationRepository>();
            services.AddScoped<IDeviceRepository, DeviceRepository>();

            // Đăng ký Background Service
            services.AddHostedService<UserSubscriptionBackgroundService>();

            // Add Authentication
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(cfg =>
            {
                cfg.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        var token = context.Request.Headers["Authorization"].FirstOrDefault();

                        // Không có prefix Bearer → dùng trực tiếp
                        if (!string.IsNullOrWhiteSpace(token) && !token.StartsWith("Bearer "))
                        {
                            context.Token = token;
                        }
                        // Có prefix → cắt bỏ
                        else if (token?.StartsWith("Bearer ") == true)
                        {
                            context.Token = token.Substring("Bearer ".Length).Trim();
                        }

                        return Task.CompletedTask;
                    }
                };
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

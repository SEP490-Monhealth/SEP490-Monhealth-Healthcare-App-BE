using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Monhealth.Application.Automapper.CustomFoodMapper.CustomMapper;
using Monhealth.Application.Contracts.Services;
using Monhealth.Application.Features.User;
using Monhealth.Application.Services;
using System.Reflection;

namespace Monhealth.Application
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddScoped<IUserContext, UserContext>();

            // services.AddScoped<IGenerateDailyMenuService, GenerateDailyMenuService>();
            services.AddAutoMapper(typeof(GetAllFoodProfile).Assembly);
            services.AddAutoMapper(typeof(GetFoodByUserIdProfile).Assembly);
            services.AddAutoMapper(typeof(GetFoodByFoodTypeProfile).Assembly);

            return services;
        }
    }
}

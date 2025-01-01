using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Monhealth.Application.Automapper;
using Monhealth.Application.Features.User;
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
            services.AddAutoMapper(typeof(FoodProfile).Assembly);
            return services;
        }
    }
}

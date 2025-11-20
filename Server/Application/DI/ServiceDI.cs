using Server.Application.Interface;
using Server.Application.Services;
using Server.Infrastructure.Repository;

namespace Server.Application.DI;

public static class ServiceDI
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepo>();

        return services;
    }
}
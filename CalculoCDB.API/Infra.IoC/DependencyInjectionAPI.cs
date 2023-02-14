using CalculoCDB.API.Application;
using Microsoft.AspNetCore.Identity;

namespace CalculoCDB.API.Infra.IoC;

public static class DependencyInjectionAPI
{
    public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddScoped<CDBService, CDBService>();

        return services;
    }
}



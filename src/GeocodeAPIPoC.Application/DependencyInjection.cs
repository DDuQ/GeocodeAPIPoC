using GeocodeAPIPoC.Application.Interfaces;
using GeocodeAPIPoC.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GeocodeAPIPoC.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IGeocodeService, GeocodeService>();
        
        return services;
    }
}

using Amazon.DynamoDBv2;
using GeocodeAPIPoC.Application.Interfaces;
using GeocodeAPIPoC.Infrastructure.Clients.Aws;
using GeocodeAPIPoC.Infrastructure.Clients.Google;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GeocodeAPIPoC.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddSingleton<IAmazonDynamoDB, AmazonDynamoDBClient>();

        var geocodingBaseUrl = configuration["GoogleMaps:GeocodingApiBaseUrl"]
                               ?? throw new InvalidOperationException(
                                   "GoogleMaps:GeocodingApiBaseUrl is not configured");

        services.AddHttpClient<IGeocodeClient, GeocodingClient>(client =>
        {
            client.BaseAddress = new Uri(geocodingBaseUrl);
        });

        services.AddScoped<IGeocodeRepository, GeocodeRepository>();

        return services;
    }
}

using GeocodeAPIPoC.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GeocodeAPIPoC.Api.Endpoints;

public static class GeocodeEndpoints
{
    public static void MapLocationEndpoints(this WebApplication app)
    {
        app.MapGet("/geocode", async ([FromQuery] string address, IGeocodeService geocoding) =>
            {
                var locationResponse = await geocoding.GetLocationByAddress(address);
                return Results.Ok(locationResponse);
            })
            .WithName("GetGeocodeByAddress");
    }
}
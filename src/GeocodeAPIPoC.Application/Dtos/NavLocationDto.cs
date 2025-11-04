using System.Text.Json.Serialization;

namespace GeocodeAPIPoC.Application.Dtos;

public class NavLocationDto
{
    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }
}
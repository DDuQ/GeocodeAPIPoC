using System.Text.Json.Serialization;

namespace GeocodeAPIPoC.Application.Dtos;

public class LocationDto
{
    [JsonPropertyName("lat")]
    public double Lat { get; set; }

    [JsonPropertyName("lng")]
    public double Lng { get; set; }
}
using System.Text.Json.Serialization;

namespace GeocodeAPIPoC.Application.Dtos;

public class BoundsDto
{
    [JsonPropertyName("northeast")]
    public LocationDto Northeast { get; set; }

    [JsonPropertyName("southwest")]
    public LocationDto Southwest { get; set; }
}
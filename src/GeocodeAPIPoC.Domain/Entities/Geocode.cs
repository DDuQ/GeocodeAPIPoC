using System.Text.Json.Serialization;

namespace GeocodeAPIPoC.Domain.Entities;

public class Geocode
{
    [JsonPropertyName("pk")] public string? Pk { get; set; }
    [JsonPropertyName("sk")] public string? Sk { get; set; }
    public List<Result>? Results { get; set; }
    public string Status { get; set; }
}

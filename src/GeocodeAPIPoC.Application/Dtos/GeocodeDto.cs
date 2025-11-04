using System.Text.Json.Serialization;

namespace GeocodeAPIPoC.Application.Dtos;

public class GeocodeDto
{
    [JsonPropertyName("results")]
    public List<ResultDto> Results { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }
}
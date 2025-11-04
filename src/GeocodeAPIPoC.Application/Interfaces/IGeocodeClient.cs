using GeocodeAPIPoC.Application.Dtos;

namespace GeocodeAPIPoC.Application.Interfaces;

public interface IGeocodeClient
{
    Task<GeocodeDto> GetGeocodeByAddress(string address);
}
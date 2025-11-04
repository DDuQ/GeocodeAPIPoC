using GeocodeAPIPoC.Domain.Entities;

namespace GeocodeAPIPoC.Application.Interfaces;

public interface IGeocodeService
{
    Task<Geocode> GetLocationByAddress(string address);
}
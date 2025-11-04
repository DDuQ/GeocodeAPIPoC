using GeocodeAPIPoC.Domain.Entities;

namespace GeocodeAPIPoC.Application.Interfaces;

public interface IGeocodeRepository
{
    Task<Geocode?> GetGeocodeByAddress(string address);
    Task<bool> CreateGeocode(Geocode geocode);
}
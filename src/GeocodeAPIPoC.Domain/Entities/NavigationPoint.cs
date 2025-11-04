namespace GeocodeAPIPoC.Domain.Entities;

public class NavigationPoint
{
    public NavLocation Location { get; set; }
    public List<string> RestrictedTravelModes { get; set; }
}

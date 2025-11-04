namespace GeocodeAPIPoC.Domain.Entities;

public class Geometry
{
    public Location Location { get; set; }
    public string LocationType { get; set; }
    public Viewport Viewport { get; set; }
    public Bounds Bounds { get; set; }
}

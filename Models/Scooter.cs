namespace Scooters.Models;
public class Scooter
{
    public Guid Id { get; set; }
    public string Number { get; set; } = null!;
    public string Model { get; set; } = null!;
    public string Latitude { get; set; } = null!;
    public string Longitude { get; set; } = null!;
    public int BatteryLevel { get; set; }
    public double Mileage { get; set; }
    public bool IsFree { get; set; }
}
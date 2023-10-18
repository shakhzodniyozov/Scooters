namespace Scooters.Models;
public class Customer
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
}
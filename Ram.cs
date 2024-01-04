namespace Garage;

public class Ram : Vehicle // Gas powered truck
{
    public double FuelCapacity { get; set; }
    public void RefuelTank()
    {
        // Method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} truck drives past. RRrruummmmmbbblle");
    }
}
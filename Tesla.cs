using System.Globalization;

namespace Garage;

public class Tesla : Vehicle  // Electric car
{
    public double BatteryKWh { get; set; }
    public void ChargeBattery()
    {
        //Method definition omitted
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"The {Make} turned {direction}.");
    }
    
}
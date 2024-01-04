using System.Globalization;

namespace Garage;

public class Vehicle
{
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }

    public string Make { get; set; }

    public virtual void Turn(string direction)
    {
        Console.WriteLine($"{direction} turn executed!");
    }

    public virtual void Stop()
    {
        Console.WriteLine("Rolling to a safe stop!");
    }

    public virtual void Drive()
    {
        Console.WriteLine("Vroom!");
    }
}
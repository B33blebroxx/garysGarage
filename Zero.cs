namespace Garage;
public class Zero : Vehicle // Electric motorcycle
{
    public double BatteryKWh { get; set; }
    public void ChargeBattery()
    {
        //method definition omitted
    }

    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} {Make} whirs to a quick stop!");
    }
}
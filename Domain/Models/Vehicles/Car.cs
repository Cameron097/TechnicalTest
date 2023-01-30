namespace Domain.Models.Vehicles;

public class Car : Vehicle
{
    public bool CarRunning => VehicleRunning;

    public Car() : base(4)
    {
    }
}
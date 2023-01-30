namespace Domain.Models.Vehicles;

public class MotorBike : Vehicle
{
    public MotorBike() : base(2)
    {

    }

    public bool MotorBikeRunning => VehicleRunning;

}
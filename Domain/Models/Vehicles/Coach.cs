namespace Domain.Models.Vehicles;

public class Coach : Vehicle
{
    public Coach() : base(25)
    {

    }
    public bool CoachRunning => VehicleRunning;
}
namespace Domain.Models.Vehicles;

public class Vehicle
{
    private readonly int _maxPassengers;

    protected Vehicle(int maxPassengers)
    {
        _maxPassengers = maxPassengers;
    }

    protected bool VehicleRunning { get; private set; }


    public void Start(IEnumerable<Person> passengers)
    {
        if (passengers == null) throw new ArgumentNullException(nameof(passengers));

        var passengersArray = passengers.ToArray();
        if (passengersArray.Length > _maxPassengers)
        {
            throw new Exception("Too many passengers");
        }

        VehicleRunning = true;
    }

    public void StartWithEmptyPeople(int peopleCount)
    {
        if (peopleCount < 1)
        {
            throw new ArgumentException("People count must be at least 1");
        }

        Start(Enumerable.Range(1, peopleCount).Select(_ => new Person()));
    }
}
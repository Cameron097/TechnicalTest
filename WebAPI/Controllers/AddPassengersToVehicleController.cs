using Domain.Models.Vehicles;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddPassengersToVehicleController : ControllerBase
    {
        [HttpGet]
        public IActionResult AddPassengersToCar(int number)
        => StartVehicleWithEmptyPeopleRequest<Car>(number);

        [HttpGet]
        public IActionResult AddPassengersToMotorBike(int number)
            => StartVehicleWithEmptyPeopleRequest<MotorBike>(number);

        [HttpGet]
        public IActionResult AddPassengersToCoach(int number)
            => StartVehicleWithEmptyPeopleRequest<Coach>(number);

        private IActionResult StartVehicleWithEmptyPeopleRequest<T>(int number) where T : Vehicle, new()
        {
            try
            {
                new T().StartWithEmptyPeople(number);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

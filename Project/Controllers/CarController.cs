using Microsoft.AspNetCore.Mvc;
using Roads.Models;

namespace Roads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {

        public static List<Car> cars = new List<Car>();

        [HttpGet("GetAllCars")]
        public List<Car> GetAll()
        {
            return cars;
        }

        [HttpPost]
        public List<Car> AddCar(Car car)
        {
            cars.Add(car);
            return cars;
        }

    }
}

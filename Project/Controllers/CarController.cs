using Microsoft.AspNetCore.Mvc;
using Roads.Models;

namespace Roads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<Car> cars = new List<Car>();

        [HttpGet("GetAllCars")]
        public List<Car> GetAll()
        {
            return cars;
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Roads.Models;
using Roads.Services.CarService;
using System.Reflection.Metadata.Ecma335;

namespace Roads.Controllers
{
/*    [Route("api/[controller]")]
    [ApiController]*/
    public class CarController : ControllerBase
    {
        public readonly CarService _carService;
        public CarController(CarService carService)
        {
            _carService = carService;
        }

        [HttpGet("Between Years")]
        public IActionResult GetCarsBetweenYears(int startYear, int endYear)
        {
            return Ok(_carService.YearsBetween(startYear, endYear));
        }


    }
}
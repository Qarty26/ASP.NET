using Microsoft.AspNetCore.Mvc;
using Roads.Models;
using Roads.Services.CarService;
using System.Reflection.Metadata.Ecma335;

namespace Roads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class CarController : ControllerBase
    {
        public readonly ICarService _carService; 
        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("BetweenYears")]
        public IActionResult GetCarsBetweenYears(int startYear, int endYear)
        {
            return Ok(_carService.YearsBetween(startYear, endYear));
        }

        [HttpDelete("DeleteById")]
        public IActionResult DeleteById(Guid id)
        {
            var deleted = _carService.DeleteCarById(id);
            return Ok(deleted);
        }

    }
}
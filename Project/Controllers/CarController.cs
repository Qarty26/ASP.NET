using Microsoft.AspNetCore.Mvc;
using Roads.Models;
using Roads.Models.DTOs;
using Roads.Services.CarService;
using System.Reflection.Metadata.Ecma335;

namespace Roads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService; 
        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet("get_interval")]
        public IActionResult GetCarsBetweenYears(int startYear, int endYear)
        {
            return Ok(_carService.YearsBetween(startYear, endYear));
        }

        [HttpGet("car/{id}")]
        public IActionResult GetCarById(Guid id)
        {
            return Ok(_carService.GetCarById(id));
        }

        [HttpGet("get_all")]
        public async Task<IActionResult> GetAllCars()
        {
            return Ok(await _carService.GetAllCars());
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateCarAsync([FromBody] CarCreateDTO car)
        {
            await _carService.CreateCar(car);
            return Ok();
        }

        [HttpPost("update")]
        public IActionResult UpdateCar([FromBody] CarDTO car)
        {
            _carService.UpdateCar(car);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteById(Guid id)
        {
            var deleted = _carService.DeleteCarById(id);
            return Ok(deleted);
        }

    }
}
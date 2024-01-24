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
        [HttpGet("Get cars between years")]
        public IActionResult GetCarsBetweenYears(int startYear, int endYear)
        {
            return Ok(_carService.YearsBetween(startYear, endYear));
        }

        [HttpGet("GetCarById")]
        public IActionResult GetCarById(Guid id)
        {
            return Ok(_carService.GetCarById(id));
        }

        [HttpGet("Get All Cars")]
        public async Task<IActionResult> GetAllCars()
        {
            return Ok(await _carService.GetAllCars());
        }

        [HttpPost("Add Car")]
        public async Task<IActionResult> CreateCarAsync(CarCreateDTO car)
        {
            await _carService.CreateCar(car);
            return Ok();
        }

        [HttpPost("Update Car")]
        public IActionResult UpdateCar(CarDTO car)
        {
            _carService.UpdateCar(car);
            return Ok();
        }

        [HttpDelete("DeleteById")]
        public IActionResult DeleteById(Guid id)
        {
            var deleted = _carService.DeleteCarById(id);
            return Ok(deleted);
        }

    }
}
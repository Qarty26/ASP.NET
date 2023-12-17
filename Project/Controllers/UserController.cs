using Microsoft.AspNetCore.Mvc;
using Roads.Models;
using Roads.Models.DTOs;
using Roads.Services.UserService;

namespace Roads.Controllers
{
/*    [Route("api/[controller]")]
    [ApiController]*/
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetByXp")]
        public IActionResult SortByXp()
        {
            return Ok(_userService.OrderByXp());
        }


/*      [HttpPost("AddCar")]
        public IActionResult AddCarToUser(CarDTO carDTO, Guid id)
        {
            User user = users.FirstOrDefault(u => u.Id == id);

            if (user != null)
            {
                if (user.Cars == null)
                {
                    user.Cars = new List<Car>();
                }

                Car car = new Car
                {
                    Make = carDTO.Make,
                    Model = carDTO.Model,
                    Year = carDTO.Year,
                    Color = carDTO.Color,
                    User = user
                };

                user.Cars.Add(car);
                return Ok($"Car added to user {id}'s garage!");
            }

            return NotFound($"User with ID {id} not found.");
        }*/

    }
}

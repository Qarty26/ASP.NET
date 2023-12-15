using Microsoft.AspNetCore.Mvc;
using Roads.Models;
using Roads.Models.DTOs;

namespace Roads.Controllers
{
/*    [Route("api/[controller]")]
    [ApiController]*/
    public class UserController : ControllerBase
    {

        public static List<User> users = new List<User>
        { };


        [HttpGet("GetAllUsers")]
        public List<User> GetAll()
        {
            return users;
        }

        [HttpPost("AddUser")]
        public List<User> AddUser(User user)
        {
            users.Add(user);
            return users;
        }

        [HttpPost("AddCar")]
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
        }

        [HttpGet("sortByXp")]
        public List<User> OrderByXp()
        {
            users = users.OrderBy(x => x.Experience).ToList();
            return users;
        }
    }
}

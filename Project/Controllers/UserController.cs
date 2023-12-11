using Microsoft.AspNetCore.Mvc;
using Roads.Models;

namespace Roads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        public IActionResult AddTrackToUser(Car car, Guid id)
        {
            User user = users.FirstOrDefault(u => u.Id == id);
            user.Cars.Add(car);

            return Ok($"Car added to user {id}'s garage!");
        }

        [HttpGet("sortByXp")]
        public List<User> OrderByXp()
        {
            users = users.OrderBy(x => x.Experience).ToList();
            return users;
        }
    }
}

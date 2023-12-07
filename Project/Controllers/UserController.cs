using Microsoft.AspNetCore.Mvc;
using Roads.Models;

namespace Roads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<User> users = new List<User>();


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

        [HttpGet("sortByXp")]
        public List<User> OrderByXp()
        {
            users = users.OrderBy(x => x.Experience).ToList();
            return users;
        }
    }
}

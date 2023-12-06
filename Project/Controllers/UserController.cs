using Microsoft.AspNetCore.Mvc;
using Roads.Models;

namespace Roads.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<User> users = new List<User>();


        [HttpGet]
        public List<User> Get()
        {
            return users;
        }

        [HttpPost]
        public List<User> AddUser(User user)
        {
            users.Add(user);
            return users;
        }

        [HttpPost("addTrack")]
        public IActionResult AddTrack(Guid id,Track track)
        {
            User user = users.FirstOrDefault(u => u.Id == id);

            if (user.Tracks == null)
                user.Tracks = new List<Track>();

            user.Tracks.Add(track);

            return Ok($"Track added to user {id}'s tracks");
        }

        [HttpGet("sortByXp")]
        public List<User> OrderByXp()
        {
            users = users.OrderBy(x => x.Experience).ToList();
            return users;
        }


        [HttpGet("sortByNoTracks")]
        public List<User> OrderByNoTracks()
        {
            users = users.OrderBy(x => x.Tracks.Count).ToList();
            return users;
        }
    }
}

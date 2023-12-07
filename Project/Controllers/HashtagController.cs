using Microsoft.AspNetCore.Mvc;
using Roads.Models;

namespace Roads.Controllers
{
    public class HashtagController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<Hashtag> hashtags = new List<Hashtag>();

        public List<Hashtag> GetAll()
        {
            return hashtags;
        }

        public List<Hashtag> AddHashtag(Hashtag hashtag)
        {
            hashtags.Add(hashtag);
            return hashtags;
        }
    }
}

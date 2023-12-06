using Microsoft.AspNetCore.Mvc;
using Roads.Models;

namespace Roads.Controllers
{
    public class TrackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public List<Track> tracks = new List<Track>();

        [HttpGet]
        public List<Track> GetAll()
        {
            return tracks;
        }

        [HttpGet("searchByHashtag")]
        public List<Track> SearchByHashtag(string hashtag)
        {
            tracks = tracks.Where(t => t.Hashtags.Contains(hashtag)).ToList();
            return tracks;
        }


        [HttpPost]
        public List<Track> Add(Track track)
        {
            tracks.Add(track);
            return tracks;
        }

        [HttpPost("addTag")]
        public IActionResult AddHashtag(Guid id, string hashtag)
        {
            Track track = tracks.FirstOrDefault(u => u.Id == id);

            if (track.Hashtags == null)
                track.Hashtags = new List<string>();

            track.Hashtags.Add(hashtag);

            return Ok($"Hashtag added to track {id}'s Hashtags");

        }
    }
}

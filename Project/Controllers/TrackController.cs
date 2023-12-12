using Microsoft.AspNetCore.Mvc;
using Roads.Models;
using Roads.Models.DTOs;

namespace Roads.Controllers
{
/*    [Route("api/[controller]")]
    [ApiController]*/
    public class TrackController : ControllerBase
    {

        public static List<Track> tracks = new List<Track>();

        [HttpGet("GetAllTracks")]
        public List<Track> GetAll()
        {
            return tracks;
        }

        [HttpPost("AddTrack")]
        public List<Track> AddTrack(Track track) 
        {
            tracks.Add(track);
            return tracks;
        }

        [HttpPost("AddTag")]
        public IActionResult AddTagToTrack(HashtagDTO hashtagDTO, Guid id)
        {
            Track track = tracks.FirstOrDefault(t => t.Id == id);

            if (track != null)
            {
                if (track.Hashtags == null)
                {
                    track.Hashtags = new List<Hashtag>();
                }

                Hashtag hashtag = new Hashtag
                {
                    Tag = hashtagDTO.Tag,
                    Track = track
                };

                track.Hashtags.Add(hashtag);
                return Ok($"Hashtag added to track {id}'s list!");
            }

            return NotFound($"Track with ID {id} not found.");
        }
    }
}

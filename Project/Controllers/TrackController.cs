using Microsoft.AspNetCore.Mvc;
using Roads.Models;
using Roads.Models.DTOs;
using Roads.Repository.TrackHashtagRepository;
using Roads.Services.TrackHashtagService;
using Roads.Services.TrackService;

namespace Roads.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
    public class TrackController : ControllerBase
    {
        private readonly ITrackService _trackService;
        private readonly ITrackHashtagService _trackHashtagService;

        public TrackController(ITrackService trackService, ITrackHashtagService trackHashtagService)
        {
            _trackService = trackService;
            _trackHashtagService = trackHashtagService;
        }

        [HttpGet("GetById")]
        public IActionResult GetTrackById(Guid id)
        {
            return Ok(_trackService.GetTrackById(id));
        }

        [HttpGet("All tracks")]
        public async Task<IActionResult> GetAllTracks()
        {
            return Ok(await _trackService.GetAll());
        }

        [HttpGet("All tracks with map")]
        public IActionResult GetAllTracksWithMaps()
        {
            return Ok(_trackService.GetAllWithMap());
        }

        [HttpGet("All tracks with tags")]
        public IActionResult GetAllTracksWithTags()
        {
            return Ok(_trackService.GetAllWithTags());
        }

        [HttpGet("All Confirmed")]
        public IActionResult AllConfirmed()
        {
            return Ok(_trackService.GetAllConfirmed());
        }

        [HttpGet("All pending")]
        public IActionResult AllPending()
        {
            return Ok(_trackService.GetAllPending())
;
        }

        [HttpGet("OrderByXp")]
        public IActionResult OrderByHighestXp()
        {
            return Ok(_trackService.OrderByHighestXp());
        }

        [HttpGet("Order by newest")]
        public IActionResult OrderByNewest()
        {
            return Ok(_trackService.OrderByNewest());
        }

        [HttpPost("Add Track")]
        public async Task<IActionResult> AddTrackAsync(TrackCreateDTO track)
        {
            await _trackService.CreateTrack(track);
            return Ok();
        }

        [HttpPost("Add Tags to Track")]
        public async Task<IActionResult> AddTagToTrack(Guid idTrack, Guid idTag)
        {
            await _trackHashtagService.AddHashtagToTrack(idTrack, idTag);
            return Ok();
        }

        [HttpPost("Update Track")]
        public IActionResult AddTrackAsync(TrackDTO track)
        {
            _trackService.Update(track);
            return Ok();
        }

        [HttpDelete("DeleteById")]
        public IActionResult DeleteById(Guid id)
        {
            var deleted = _trackService.DeleteTrackById(id);
            return Ok(deleted);
        }


        /*        [HttpPost("AddTag")]
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
                }*/
    }
}

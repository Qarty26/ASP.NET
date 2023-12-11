using Microsoft.AspNetCore.Mvc;
using Roads.Models;

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
    }
}

using Microsoft.AspNetCore.Mvc;
using Roads.Models;
using Roads.Models.DTOs;
using Roads.Repository.TrackHashtagRepository;
using Roads.Services.TrackHashtagService;
using Roads.Services.TrackService;
using Roads.Services.UnitOfWorkService;

namespace Roads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackController : ControllerBase
    {
        private readonly ITrackService _trackService;
        private readonly ITrackHashtagService _trackHashtagService;
        private readonly IUnitOfWorkService _unitOfWorkService;

        public TrackController(ITrackService trackService, ITrackHashtagService trackHashtagService, IUnitOfWorkService unitOfWorkService)
        {
            _trackService = trackService;
            _trackHashtagService = trackHashtagService;
            _unitOfWorkService = unitOfWorkService;
        }

        [HttpGet("track/{id}")]
        public IActionResult GetTrackById(Guid id)
        {
            return Ok(_trackService.GetTrackById(id));
        }

        [HttpGet("get_all")]
        public async Task<IActionResult> GetAllTracks()
        {
            return Ok(await _trackService.GetAll());
        }

        [HttpGet("get_map")]
        public IActionResult GetAllTracksWithMaps()
        {
            return Ok(_trackService.GetAllWithMap());
        }

        [HttpGet("get_tag")]
        public IActionResult GetAllTracksWithTags()
        {
            return Ok(_trackService.GetAllWithTags());
        }

        [HttpGet("get_confirmed")]
        public IActionResult AllConfirmed()
        {
            return Ok(_trackService.GetAllConfirmed());
        }

        [HttpGet("get_pending")]
        public IActionResult AllPending()
        {
            return Ok(_trackService.GetAllPending())
;
        }

        [HttpGet("get_by_xp")]
        public IActionResult OrderByHighestXp()
        {
            return Ok(_trackService.OrderByHighestXp());
        }

        [HttpGet("get_by_newest")]
        public IActionResult OrderByNewest()
        {
            return Ok(_trackService.OrderByNewest());
        }

        [HttpPost("create")]
        public async Task<IActionResult> AddTrackAsync([FromBody] TrackCreateDTO track)
        {
            await _trackService.CreateTrack(track);
            await _unitOfWorkService.SaveAllAsync();
            return Ok();
        }

        [HttpPost("add_tag")]
        public async Task<IActionResult> AddTagToTrack(Guid idTrack, Guid idTag)
        {
            await _trackHashtagService.AddHashtagToTrack(idTrack, idTag);
            await _unitOfWorkService.SaveAllAsync();
            return Ok();
        }

        [HttpPost("update")]
        public IActionResult AddTrackAsync([FromBody] TrackDTO track)
        {
            _trackService.Update(track);
            _unitOfWorkService.SaveAll();
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteById(Guid id)
        {
            var deleted = _trackService.DeleteTrackById(id);
            _unitOfWorkService.SaveAll();
            return Ok(deleted);
        }


    }
}
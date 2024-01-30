using Microsoft.AspNetCore.Mvc;
using Roads.Models;
using Roads.Models.DTOs;
using Roads.Services.HashtagService;

namespace Roads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HashtagController : ControllerBase
    {
        private readonly IHashtagService _hashtagService;

        public HashtagController(IHashtagService hashtagService)
        {
            _hashtagService = hashtagService;
        }

        [HttpGet("get_all")]
        public IActionResult GetAllTags()
        {
            return Ok(_hashtagService.GetAllHashtags());
        }

        [HttpGet("tag/{id}")]
        public IActionResult GetTagById(Guid id)
        {
            return Ok(_hashtagService.GetHashtagById(id));
        }

        [HttpPost("create")]
        public async Task<IActionResult> AddTag([FromBody] HashtagCreateDTO tag)
        {
            await _hashtagService.CreateHashtag(tag);
            return Ok(tag);
        }

        [HttpPost("update")]
        public IActionResult UpdateTag([FromBody] HashtagDTO tag)
        {
            _hashtagService.UpdateHashtag(tag);
            return Ok(tag);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteById(Guid id)
        {
            var deleted = _hashtagService.DeleteHashtagById(id);
            return Ok(deleted);
        }


    }
}

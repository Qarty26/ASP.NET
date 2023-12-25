using Microsoft.AspNetCore.Mvc;
using Roads.Models;
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

        [HttpGet("GetAllTags")]
        public IActionResult GetAllTags()
        {
            return Ok(_hashtagService.GettAllHashtags());
        }

        [HttpGet("GetTagById")]
        public IActionResult GetTagById(Guid id)
        {
            return Ok(_hashtagService.GetHashtagById(id));
        }

        [HttpDelete("DeleteById")]
        public IActionResult DeleteById(Guid id)
        {
            var deleted = _hashtagService.DeleteHashtagById(id);
            return Ok(deleted);
        }

        //todo
        /*        [HttpPost("AddHashtag")]
                public IActionResult AddTag(Hashtag tag)
                {
                    return Ok(_hashtagService.AddTag(tag));
                }*/
    }
}

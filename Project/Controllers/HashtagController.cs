using Microsoft.AspNetCore.Mvc;
using Roads.Models;
using Roads.Services.HashtagService;

namespace Roads.Controllers
{
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

//todo
/*        [HttpPost("AddHashtag")]
        public IActionResult AddTag(Hashtag tag)
        {
            return Ok(_hashtagService.AddTag(tag));
        }*/
    }
}

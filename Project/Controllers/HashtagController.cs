using Microsoft.AspNetCore.Mvc;
using Roads.Models;
using Roads.Models.DTOs;
using Roads.Services.HashtagService;
using Roads.Services.UnitOfWorkService;

namespace Roads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HashtagController : ControllerBase
    {
        private readonly IHashtagService _hashtagService;
        private readonly IUnitOfWorkService _unitOfWorkService;

        public HashtagController(IHashtagService hashtagService, IUnitOfWorkService unitOfWorkService)
        {
            _hashtagService = hashtagService;
            _unitOfWorkService = unitOfWorkService;
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
            await _unitOfWorkService.SaveAllAsync();
            return Ok(tag);
        }

        [HttpPost("update")]
        public IActionResult UpdateTag([FromBody] HashtagDTO tag)
        {
            _hashtagService.UpdateHashtag(tag);
            _unitOfWorkService.SaveAll();
            return Ok(tag);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteById(Guid id)
        {
            var deleted = _hashtagService.DeleteHashtagById(id);
            _unitOfWorkService.SaveAll();
            return Ok(deleted);
        }


    }
}

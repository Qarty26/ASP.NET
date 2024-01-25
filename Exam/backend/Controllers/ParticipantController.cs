using Exam.Models.DTO;
using Exam.Services.EventService;
using Exam.Services.ParticipantService;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Controllers
{
    public class ParticipantController : Controller
    {
        private readonly IParticipantService _participantService;

        public ParticipantController(IParticipantService participantService)
        {
            _participantService = participantService;
        }

        [HttpGet("all2")]
        public async Task<IActionResult> GetParticipants()
        {
            return Ok(await _participantService.GetAll());
        }

        [HttpPost("create2")]
        public async Task<IActionResult> CreateParticipant([FromBody] ParticipantDTO test)
        {
            await _participantService.Create(test);
            return Ok();
        }


        [HttpDelete("delete2/${id}")]
        public IActionResult DeleteParticipant(Guid id)
        {
            _participantService.Delete(id);
            return Ok();
        }
    }
}

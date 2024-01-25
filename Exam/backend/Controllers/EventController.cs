using Exam.Models;
using Exam.Models.DTO;
using Exam.Repository.EventRepository;
using Exam.Services.EventParticipantService;
using Exam.Services.EventService;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService _eventService;
        private readonly IEventParticipantService _eventParticipantService;

        public EventController(IEventService eventService, IEventParticipantService eventParticipantService)
        {
            _eventService = eventService;
            _eventParticipantService = eventParticipantService;
        }

        [HttpGet("all1")]
        public async Task<IActionResult> GetEvents()
        {
            return Ok(await _eventService.GetAll());
        }

        [HttpPost("create1")]
        public async Task<IActionResult> CreateEvent([FromBody] EventDTO test)
        {
            await _eventService.Create(test);
            return Ok();
        }

        [HttpPost("create_event_with_part")]
        public async Task<IActionResult> CreateEventParticipant(Guid idEvent, Guid idParticipant)
        {
            await _eventParticipantService.AddEventParticipant(idEvent, idParticipant);
            return Ok();
        }

        [HttpGet("alleventswithparti")]
        public async Task<IActionResult> GetEventParticipant()
        {
            await _eventParticipantService.GetAll();
            return Ok();
        }

/*        [HttpGet("all_event_wtih_part_v2")]
        public async Task<IActionResult> GetEventParticipantv2()
        {
            await _eventService.GetAllWithEvAndPart();
            return Ok();
        }
*/

        [HttpDelete("delete1/${id}")]
        public IActionResult DeleteEvent(Guid id)
        {
            _eventService.Delete(id);
            return Ok();
        }
    }
}

using AutoMapper;
using Exam.Models;
using Exam.Models.DTO;
using Exam.Repository.EventRepository;

namespace Exam.Services.EventService
{
    public class EventService : IEventService
    {
        public IEventRepository _eventRepository;
        public IMapper _mapper;

        public EventService(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<List<EventDTO>> GetAll()
        {
            var events = await _eventRepository.GetAllAsync();
            return _mapper.Map<List<EventDTO>>(events);
        }

        public void Delete(Guid id)
        {
            _eventRepository.DeleteById(id);
            _eventRepository.SaveAsync();
        }

        public async Task Create(EventDTO eventDTO)
        {
            var ev = _mapper.Map<Event>(eventDTO);
            await _eventRepository.CreateAsync(ev);

        }

/*        public List<EventWithPartDTO> GetAllWithEvAndPart()
        {
            var tracks = _eventRepository.GetAllEvPart();
            return _mapper.Map<List<TrackWithTagsDTO>>(tracks);
        }*/


    }
}

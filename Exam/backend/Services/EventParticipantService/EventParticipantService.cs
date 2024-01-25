using AutoMapper;
using Exam.Models;
using Exam.Models.DTO;
using Exam.Repository.EventParticipantRepository;
using Exam.Repository.EventRepository;
using Exam.Repository.ParticipantRepository;

namespace Exam.Services.EventParticipantService
{
    public class EventParticipantService : IEventParticipantService
    {
        public IMapper _mapper;
        public IEventRepository _eventRepository;
        public IParticipantRepository _participantRepository;
        public IEventParticipantRepository _eventParticipantRepository;

        public EventParticipantService(IMapper mapper, IEventRepository eventRepository, IParticipantRepository participantRepository, IEventParticipantRepository eventParticipantRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
            _participantRepository = participantRepository;
            _eventParticipantRepository = eventParticipantRepository;
        }

        public async Task AddEventParticipant(Guid idEvent, Guid idParticipant)
        {
            await _eventParticipantRepository.CreateAsync(_mapper.Map<EventParticipantRelation>(new EventParticipantDTO()
            {
                IdEvent = idEvent,
                IdParticipant = idParticipant
            }));

            await _eventParticipantRepository.SaveAsync();
        }

        public async Task<List<EventParticipantDTO>> GetAll()
        {
            var ev = await _eventParticipantRepository.GetAllAsync();
            return _mapper.Map<List<EventParticipantDTO>>(ev);
        }
    }
}

using AutoMapper;
using Exam.Models.DTO;
using Exam.Models;
using Exam.Repository.ParticipantRepository;

namespace Exam.Services.ParticipantService
{
    public class ParticipantService : IParticipantService
    {
        public IParticipantRepository _participantRepository;
        public IMapper _mapper;

        public ParticipantService(IParticipantRepository participantRepository, IMapper mapper)
        {
            _participantRepository = participantRepository;
            _mapper = mapper;
        }

        public async Task<List<ParticipantDTO>> GetAll()
        {
            var participants = await _participantRepository.GetAllAsync();
            return _mapper.Map<List<ParticipantDTO>>(participants);
        }

        public void Delete(Guid id)
        {
            _participantRepository.DeleteById(id);
            _participantRepository.SaveAsync();
        }

        public async Task Create(ParticipantDTO participantDTO)
        {
            var pa = _mapper.Map<Participant>(participantDTO);
            await _participantRepository.CreateAsync(pa);

        }
    }
}

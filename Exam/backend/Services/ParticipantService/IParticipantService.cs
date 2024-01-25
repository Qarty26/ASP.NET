using Exam.Models.DTO;

namespace Exam.Services.ParticipantService
{
    public interface IParticipantService
    {
        Task<List<ParticipantDTO>> GetAll();
        void Delete(Guid id);
        Task Create(ParticipantDTO participantDTO);
    }
}

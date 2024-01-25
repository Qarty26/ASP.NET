using Exam.Models.DTO;

namespace Exam.Services.EventParticipantService
{
    public interface IEventParticipantService
    {
        Task<List<EventParticipantDTO>> GetAll();
        Task AddEventParticipant(Guid idEvent, Guid idParticipant);
    }
}

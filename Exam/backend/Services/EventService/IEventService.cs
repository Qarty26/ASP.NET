using Exam.Models.DTO;

namespace Exam.Services.EventService
{
    public interface IEventService
    {
        Task<List<EventDTO>> GetAll();
        void Delete(Guid id);
        Task Create(EventDTO eventDTO);
    }
}

using Exam.Data;
using Exam.Models;
using Exam.Repository.GenericRepository;

namespace Exam.Repository.EventParticipantRepository
{
    public class EventParticipantRepository : GenericRepository<EventParticipantRelation>, IEventParticipantRepository
    {
        public EventParticipantRepository(DatabaseContext dbContext) : base(dbContext) { }

    }
}

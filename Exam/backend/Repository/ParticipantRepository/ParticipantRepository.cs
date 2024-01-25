using Exam.Data;
using Exam.Models;
using Exam.Repository.EventRepository;
using Exam.Repository.GenericRepository;

namespace Exam.Repository.ParticipantRepository
{
    public class ParticipantRepository : GenericRepository<Participant>, IParticipantRepository
    {
        public ParticipantRepository(DatabaseContext dbContext) : base(dbContext) { }
    }
}

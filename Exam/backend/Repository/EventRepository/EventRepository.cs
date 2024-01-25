using Exam.Data;
using Exam.Models;
using Exam.Repository.GenericRepository;
using Exam.Repository.TestRepository;

namespace Exam.Repository.EventRepository
{
    public class EventRepository : GenericRepository<Event>, IEventRepository
    {
        public EventRepository(DatabaseContext dbContext) : base(dbContext) { }
    }

/*    public List<Event> GetAllEvPart()
    {
        return _table.AsNoTracking()
            .Include(t => t.Map)
            .ToList();
    }*/
}

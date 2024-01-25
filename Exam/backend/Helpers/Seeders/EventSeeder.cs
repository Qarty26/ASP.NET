using Exam.Data;
using Exam.Models;

namespace Exam.Helpers.Seeders
{
    public class EventSeeder
    {

        private readonly DatabaseContext _dbContext;

        public EventSeeder(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SeedInitialEvents()
        {
            if (!_dbContext.Events.Any())
            {
                var event1 = new Event()
                {
                    Id = Guid.NewGuid(),
                    Name = "Nunta",
                    DateCreated = DateTime.Now,
                    LastModified = DateTime.Now
                };

                var event2 = new Event()
                {
                    Id = Guid.NewGuid(),
                    Name = "Botez",
                    DateCreated = DateTime.Now,
                    LastModified = DateTime.Now
                };

                _dbContext.Events.Add(event1);
                _dbContext.Events.Add(event2);
                _dbContext.SaveChanges();
            }
        }
    }
}

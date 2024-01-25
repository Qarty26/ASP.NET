using Exam.Data;
using Exam.Models;

namespace Exam.Helpers.Seeders
{
    public class ParticipantSeeder
    {
        private readonly DatabaseContext _dbContext;

        public ParticipantSeeder(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SeedInitialParticipants()
        {
            if (!_dbContext.Participants.Any())
            {
                var p1 = new Participant()
                {
                    Id = Guid.NewGuid(),
                    Name = "Andrei",
                    DateCreated = DateTime.Now,
                    LastModified = DateTime.Now,
                    Role = Data.Enums.Role.Spectator
                };

                var p2 = new Participant()
                {
                    Id = Guid.NewGuid(),
                    Name = "George",
                    DateCreated = DateTime.Now,
                    LastModified = DateTime.Now,
                    Role = Data.Enums.Role.Spectator
                };

                _dbContext.Participants.Add(p1);
                _dbContext.Participants.Add(p2);
                _dbContext.SaveChanges();
            }
        }
    }
}

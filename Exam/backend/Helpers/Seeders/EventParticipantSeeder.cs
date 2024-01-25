using Exam.Data;
using Exam.Models;

namespace Exam.Helpers.Seeders
{
    public class EventParticipantSeeder
    {
        private readonly DatabaseContext _dbContext;

        public EventParticipantSeeder(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SeedInitialEventParticipants()
        {
            if (!_dbContext.EventParticipantRelations.Any())
            {
                var r1 = new EventParticipantRelation()
                {
                    Id = Guid.NewGuid(),
                    IdEvent = new Guid("8a0e306f-36a8-48b5-b901-7c6917ca748e"),
                    IdParticipant = new Guid("f1eae258-da22-4bfc-b3ee-ce177a7178fb")
                };

                var r2 = new EventParticipantRelation()
                {
                    Id = Guid.NewGuid(),
                    IdEvent = new Guid("1d0ca88d-cb00-4ad5-afc0-86d5490bd6e7"),
                    IdParticipant = new Guid("12b0cef6-0325-4035-a718-f494b6d8d5e0")
                };

                _dbContext.EventParticipantRelations.Add(r1);
                _dbContext.EventParticipantRelations.Add(r2);
                _dbContext.SaveChanges();
            }
        }
    }
}

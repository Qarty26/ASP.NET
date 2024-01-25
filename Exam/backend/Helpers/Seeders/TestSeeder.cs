using Exam.Data;
using Exam.Models;

namespace Exam.Helpers.Seeders
{
    public class TestSeeder
    {
        private readonly DatabaseContext _dbContext;

        public TestSeeder(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SeedInitialTests()
        {
            if (!_dbContext.Tests.Any())
            {
                var tests = new List<Test>
            {
                new Test()
                {
                    Id = new Guid(),
                    Name = "test_1",
                    DateCreated = DateTime.Now,
                    LastModified = DateTime.Now
                },
                new Test()
                {
                    Id = new Guid(),
                    Name = "test_2",
                    DateCreated = DateTime.Now,
                    LastModified = DateTime.Now
                },
                new Test()
                {
                    Id = new Guid(),
                    Name = "test_3",
                    DateCreated = DateTime.Now,
                    LastModified = DateTime.Now
                }
            };

                _dbContext.Tests.AddRange(tests);
                _dbContext.SaveChanges();
            }
        }
    }
}

using Exam.Data;
using Exam.Models;
using Exam.Repository.GenericRepository;

namespace Exam.Repository.TestRepository
{
    public class TestRepository : GenericRepository<Test>, ITestRepository
    {
        public TestRepository(DatabaseContext dbContext) : base(dbContext) { }
    }
}

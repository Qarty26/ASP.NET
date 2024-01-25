using Exam.Models;
using Exam.Repository.GenericRepository;

namespace Exam.Repository.TestRepository
{
    public interface ITestRepository : IGenericRepository<Test>
    {
    }
}

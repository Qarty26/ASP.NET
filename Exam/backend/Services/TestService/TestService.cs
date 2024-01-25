using Exam.Models;
using Exam.Repository.TestRepository;

namespace Exam.Services.TestService
{
    public class TestService : ITestService
    {
        private readonly ITestRepository _testRepository;

        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public async Task<List<Test>> GetAll()
        {
            return await _testRepository.GetAllAsync();
        }

        public async Task Create(Test test)
        {
            await _testRepository.CreateAsync(test);
            await _testRepository.SaveAsync();
        }

        public void Delete(Guid id)
        {
            _testRepository.DeleteById(id);
            _testRepository.SaveAsync();
        }

        public async Task Update(Test test)
        {
            _testRepository.Update(test);
            await _testRepository.SaveAsync();
        }
    }
}

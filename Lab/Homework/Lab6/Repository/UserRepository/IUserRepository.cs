using Lab3_2.Models;
using Lab3_2.Repository.GenericRepository;

namespace Lab3_2.Repository.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User FindByUsername(string username);

        List<User> FindAllActive();
    }
}

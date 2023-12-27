using Roads.Models;
using Roads.Repository.GenericRepository;

namespace Roads.Repository.UserRepository
{
    public interface IUserRepository
    {
        Task CreateAsync(User user);
        Task<User>? GetUserById(Guid id);
        Task Update(User user);
        Task Delete(Guid id);
/*        List<User> OrderByXp();*/
    }
}

using Roads.Models;
using Roads.Models.DTOs;
using Roads.Repository.GenericRepository;

namespace Roads.Repository.UserRepository
{
    public interface IUserRepository
    {
        Task CreateAsync(User user);
        Task<User> GetUserById(Guid id);
        Task Delete(Guid id);
        Task<List<User>> GetUsersAsync();
        Task Update(User user);
        Task<List<User>> OrderByXp();
        Task<List<User>> GetUsersWIthCarsAndTracksAsync();
    }
}

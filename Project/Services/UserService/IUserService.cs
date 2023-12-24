using Roads.Models;
using Roads.Models.DTOs;

namespace Roads.Services.UserService
{
    public interface IUserService
    {
        List<User> OrderByXp();
        bool DeleteUserById(Guid id);
    }
}

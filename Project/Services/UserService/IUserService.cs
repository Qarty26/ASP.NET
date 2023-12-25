using Roads.Models;
using Roads.Models.DTOs;

namespace Roads.Services.UserService
{
    public interface IUserService
    {
        List<User> OrderByXp();
        UserDTO GetUserById(Guid id);
        bool DeleteUserById(Guid id);
    }
}

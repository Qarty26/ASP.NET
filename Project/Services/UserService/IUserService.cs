using Roads.Models;
using Roads.Models.DTOs;

namespace Roads.Services.UserService
{
    public interface IUserService
    {
        Task<UserDTO> GetUserById(Guid id);
 /*       List<User> OrderByXp();*/
    }
}

using Roads.Models;
using Roads.Models.DTOs;

namespace Roads.Services.UserService
{
    public interface IUserService
    {
        Task<UserDTO> GetUserById(Guid id);
        Task<UserDTO> CreateAsync(UserCreateDTO user);
        Task Delete(Guid id);
        Task<List<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> Update(UserUpdateDTO user);

 /*       List<User> OrderByXp();*/
    }
}

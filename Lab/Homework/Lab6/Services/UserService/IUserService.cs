using Lab3_2.Models;
using Lab3_2.Models.DTOs;

namespace Lab3_2.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();

        UserDTO getUserByUsername(string username);
    }
}

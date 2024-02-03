using Roads.Models;
using Roads.Models.DTOs;
using Roads.Models.Errors;

namespace Roads.Services.UserService
{
    public interface IUserService
    {
        Task<UserDTO> GetUserById(Guid id);
        Task<UserDTO> CreateAsync(UserCreateDTO user);
        Task Delete(Guid id);
        Task<List<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> Update(UserUpdateDTO user);
        Task<ErrorResponse> SignUp(UserSignUpDTO signup);
        Task<Guid> Login(LoginDTO loginDto);
        Task Logout();
        Task<ErrorResponse> ConfirmEmail(string email, string token);
        Task<List<UserDTO>> OrderByXp();
        Task<List<UserWithCarAndTrackDTO>> GetAllUsersWithCarsAndTracksAsync();
    }
}

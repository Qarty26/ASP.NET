using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Roads.Models;
using Roads.Models.DTOs;
using Roads.Repository.UserRepository;

namespace Roads.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;

        public UserService(IUserRepository userRepository, IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        public async Task<UserDTO> CreateAsync(UserCreateDTO user)
        {
            var newUser = _mapper.Map<User>(user);
            await _userRepository.CreateAsync(newUser);
            return _mapper.Map<UserDTO>(newUser);
        }

        public async Task<UserDTO> GetUserById(Guid id)
        {
            var user = await _userRepository.GetUserById(id);
            if (user == null) throw new Exception("Invalid user");
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<List<UserDTO>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetUsersAsync();
            if (users == null) throw new Exception("No users found");
            return _mapper.Map<List<UserDTO>>(users);
        }
        public async Task Delete(Guid id)
        {
            await _userRepository.Delete(id);
        }

        public async Task<UserDTO> Update(UserUpdateDTO user)
        {
            var existingUser = await _userRepository.GetUserById(user.Id);

            if (existingUser == null)
            {
                throw new Exception("User not found");
            }

            var hasher = new PasswordHasher<User>();
            if (user.UserName != null) existingUser.UserName = user.UserName;
            if (user.FirstName != null) existingUser.FirstName = user.FirstName;
            if (user.LastName != null) existingUser.LastName = user.LastName;
            if (user.Email != null) existingUser.Email = user.Email;
            if (user.Password != null) existingUser.PasswordHash = hasher.HashPassword(null, user.Password);

            await _userRepository.Update(existingUser);
            return _mapper.Map<UserDTO>(existingUser);
        }



    }


    /*        public List<User> OrderByXp()
            {
                var leaderboardByXp = _userRepository.OrderByXp();
                return _mapper.Map<List<User>>(leaderboardByXp);
            }*/

}


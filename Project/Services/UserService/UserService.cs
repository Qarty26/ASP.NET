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

        public UserService(IUserRepository userRepository, IMapper mapper, UserManager<User> userManager)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<UserDTO> CreateAsync(UserDTO user)
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

        public async Task Delete(Guid id)
        {
            await _userRepository.Delete(id);
        }


/*        public List<User> OrderByXp()
        {
            var leaderboardByXp = _userRepository.OrderByXp();
            return _mapper.Map<List<User>>(leaderboardByXp);
        }*/

    }
}

using AutoMapper;
using Roads.Models;
using Roads.Models.DTOs;
using Roads.Repository.UserRepository;

namespace Roads.Services.UserService
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        public IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public UserDTO GetUserById(Guid id)
        {
            var user = _userRepository.FindById(id);
            return _mapper.Map<UserDTO>(user);
        }

        public List<User> OrderByXp()
        {
            var leaderboardByXp = _userRepository.OrderByXp();
            return _mapper.Map<List<User>>(leaderboardByXp);
        }

        public bool DeleteUserById(Guid id)
        {
            return _userRepository.DeleteById(id);
        }
    }
}

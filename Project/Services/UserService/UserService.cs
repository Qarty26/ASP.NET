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

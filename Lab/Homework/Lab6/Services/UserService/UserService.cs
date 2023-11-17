using AutoMapper;
using Lab3_2.Models;
using Lab3_2.Models.DTOs;
using Lab3_2.Repository.UserRepository;

namespace Lab3_2.Services.UserService
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        public IMapper _mapper;

        public UserService(IUserRepository userRepository,IMapper mapper)
        {
            userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<User>> GetAllUsers()
        {
            var userList = await _userRepository.GetAllAsync();
            return _mapper.Map<List<User>>(userList);

        }

        public UserDTO getUserByUsername(string username)
        {
            var user = _userRepository.FindByUsername(username);
            
            //echivalent cu

/*            var userDTO = new UserDTO();
            userDTO.Username = user.Username;
            userDTO.Email = user.Username;
            userDTO.FullName = user.FirstName + user.LastName;*/

            return _mapper.Map<UserDTO>(user);
            

        }
    }
}

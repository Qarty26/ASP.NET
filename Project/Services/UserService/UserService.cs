using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Roads.Models;
using Roads.Models.DTOs;
using Roads.Models.Errors;
using Roads.Repository.UserRepository;

namespace Roads.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        //will be used for smtp 
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

        public async Task<List<UserWithCarAndTrackDTO>> GetAllUsersWithCarsAndTracksAsync()
        {
            var users = await _userRepository.GetUsersWIthCarsAndTracksAsync();
            if (users == null) throw new Exception("No users found");
            return _mapper.Map<List<UserWithCarAndTrackDTO>>(users);
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

        public async Task<Guid> Login(LoginDTO loginDto)
        {
            var email = await _userManager.FindByEmailAsync(loginDto.Email);
            if (email == null)
            {
                throw new Exception("The email does not exist");
            }

            var result = await _signInManager.CheckPasswordSignInAsync(email, loginDto.Password, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(email, isPersistent: true);
                return email.Id;
            }

            throw new Exception("Wrong password");
        }

        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<ErrorResponse> SignUp(UserSignUpDTO signup)
        {
            var existsUser = await _userManager.FindByEmailAsync(signup.Email);

            if (existsUser != null)
                throw new Exception("Email is already used");

            var user = _mapper.Map<User>(signup);
            var result = await _userManager.CreateAsync(user);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Regular");

                return new ErrorResponse()
                {
                    StatusCode = 200,
                    Message = "Register was successful"
                };
            }
            throw new Exception(result.Errors.First().Description);
        }

        public async Task<ErrorResponse> ConfirmEmail(string email, string token)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return new ErrorResponse()
                {
                    StatusCode = 400,
                    Message = "There is no user with this email"
                };
            }

            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                return new ErrorResponse()
                {
                    StatusCode = 200,
                    Message = "Confirmation successfull"
                };
            }

            return new ErrorResponse()
            {
                StatusCode = 500,
                Message = "Confirmation failed"
            };
        }

        public async Task StoreDeviceToken(string IdUser, string deviceToken)
        {
            var user = await _userRepository.GetUserById(new Guid(IdUser));
            
            if (user == null)
            {
                throw new Exception("User not found");
            }

            user.DeviceToken = deviceToken;
            await _userRepository.Update(user);
        }



        public async Task<List<UserDTO>> OrderByXp()
        {
            var leaderboardByXp = await _userRepository.OrderByXp();
            return _mapper.Map<List<UserDTO>>(leaderboardByXp);
        }
    }
}


using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Roads.Models;
using Roads.Models.DTOs;
using Roads.Services.UserCarService;
using Roads.Services.UserService;
using Roads.Services.UserTrackCarService;

namespace Roads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        private readonly IUserCarService _userCarService;
        private readonly IUserTrackCarService _userTrackCarService;

        public UserController(IUserService userService, IUserCarService userCarService, IUserTrackCarService userTrackCarService)
        {
            _userService = userService;
            _userCarService = userCarService;
            _userTrackCarService = userTrackCarService;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromBody] UserSignUpDTO user)
        {
            return Ok(await _userService.SignUp(user));
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDTO user)
        {
            return Ok(await _userService.Login(user));
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            await _userService.Logout();
            return Ok();
        }

        [HttpGet("confirm_email")]
        public async Task<IActionResult> ConfirmEmail(string email, string token)
        {
            return Ok(await _userService.ConfirmEmail(email, token));
        }


        [HttpGet("user/{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _userService.GetUserById(id));
        }

        [HttpGet("get_all")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _userService.GetAllUsersAsync());
        }

        [HttpGet("get_full")]
        public async Task<IActionResult> GetAllUsersWithCarsAndTracks()
        {
            return Ok(await _userService.GetAllUsersWithCarsAsync());
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateUserAsync(UserCreateDTO user)
        {
            return Ok(await _userService.CreateAsync(user));
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateUserAsync([FromBody] UserUpdateDTO user)
        {
            return Ok(await _userService.Update(user));
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteUserAsync(Guid id)
        {
            await _userService.Delete(id);
            return Ok();
        }


        [HttpGet("get_by_xp")]
        public async Task<IActionResult> SortByXp()
        {
            return Ok(await _userService.OrderByXp());
        }

        [HttpPost("add_car")]
        public async Task<IActionResult> AddCarToUser(Guid idCar, Guid idUser)
        {
            await _userCarService.AddCarToUser(idCar, idUser);
            return Ok();
        }

        [HttpPost("create_car")]
        public async Task<IActionResult> CreateCarToUser(CarDTO car, Guid idUser)
        {
            await _userCarService.CreateCarToUser(car, idUser);
            return Ok();
        }

        [HttpPost("add_track_car")]
        public async Task<IActionResult> AddTrackWithCarToUser(Guid idTrack, Guid idCar, Guid idUser)
        {
            await _userTrackCarService.AddTrackWithCarToUser(idTrack, idCar, idUser);
            return Ok();
        }
    }
}
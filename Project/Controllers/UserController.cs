using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Roads.Models;
using Roads.Models.DTOs;
using Roads.Services.UserCarService;
using Roads.Services.UserService;

namespace Roads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        private readonly IUserCarService _userCarService;

        public UserController(IUserService userService, IUserCarService userCarService)
        {
            _userService = userService;
            _userCarService = userCarService;
        }

        [HttpGet("Get user by id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _userService.GetUserById(id));
        }

        [HttpGet("Get all users")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _userService.GetAllUsersAsync());
        }

        [HttpPost("Create user")]
        public async Task<IActionResult> CreateUserAsync(UserCreateDTO user)
        {
            return Ok(await _userService.CreateAsync(user));
        }

        [HttpPost("Update user")]
        public async Task<IActionResult> UpdateUserAsync(UserUpdateDTO user)
        {
            return Ok(await _userService.Update(user));
        }

        [HttpDelete("Delete user")]
        public async Task<IActionResult> DeleteUserAsync(Guid id)
        {
            await _userService.Delete(id);
            return Ok();
        }



        /*        [HttpGet("GetByXpDescending")]
                public IActionResult SortByXp()
                {
                    return Ok(_userService.OrderByXp());
                }*/

        //todo
        /*        [HttpPost("Add car to user")]
                public IActionResult AddCarToUser(CarDTO carDTO, Guid id)
                {
                    return Ok(_userCarService.AddCarToUser(carDTO, id));
                }*/
    }
}

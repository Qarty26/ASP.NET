﻿using Microsoft.AspNetCore.Mvc;
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

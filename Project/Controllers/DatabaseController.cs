using Microsoft.AspNetCore.Mvc;
using Roads.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace Roads.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private readonly RoadsContext _roadsContext;
        public DatabaseController(RoadsContext roadsContext)
        {
            _roadsContext = roadsContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _roadsContext.Users.ToListAsync());
        }

    }
}

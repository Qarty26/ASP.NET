using Lab3_2.Data;
using Lab3_2.Models.DTOs;
using Lab3_2.Models.One_to_Many;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab3_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        private readonly Lab4Context _lab4Context;
        public DatabaseController(Lab4Context lab4Context)
        {
            _lab4Context = lab4Context;
        }

        [HttpGet("model1")]
        public async Task<IActionResult> GetModel1()
        {
            return Ok(await _lab4Context.Students2.ToListAsync());
        }

        [HttpPost("model1")]

        public async Task<IActionResult> Create (Model1DTO model1Dto)
        {
            var newModel1 = new Model1();
            newModel1.Id = Guid.NewGuid();
            newModel1.Name = model1Dto.Name;

            await _lab4Context.AddAsync(newModel1);
            await _lab4Context.SaveChangesAsync();

            return Ok(newModel1);  
        }

        [HttpPost("update")]

        public async Task<IActionResult> Update(Model1DTO model1Dto)
        {
            Model1 modelById = await _lab4Context.Models1.FirstOrDefaultAsync(x => x.Id == model1Dto.Id);

            if(modelById == null)
            {
                return BadRequest("Invalid object");
            }
            modelById.Name = model1Dto.Name;
            await _lab4Context.SaveChangesAsync();
            return Ok(modelById);
        }
    }
}
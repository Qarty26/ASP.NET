using Lab2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.FileProviders;

namespace Lab2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Radu", Age = 20},
            new Student { Id = 2, Name = "Mircea", Age = 19},
            new Student { Id = 3, Name = "Dogaru", Age = 21},
            new Student { Id = 4, Name = "Mincu", Age = 24},
            new Student { Id = 5, Name = "Stanescu", Age = 18}
        };


        [HttpGet]
        public List<Student> Get()
        {
            return students;
        }

        [HttpPost]

        public List<Student> Add(Student student)
        {
            students.Add(student); 
            return students;
        }
        /*
              [HttpDelete]

                public List <Student> Delete(Student student)
              {
                students.Remove(student);
                return students;
              }

              [HttpDelete]
              public List<Student> Deletev2(Student student)
              {
                  var studentIndex = students.FindIndex(x => x.Id == student.Id);
                  students.RemoveAt(studentIndex);
                  return students;
              }

                */

       [HttpDelete]

       public List<Student> DeleteId(int Id)
        {
            var studentId = students.Find(x => x.Id == Id);
            students.Remove(studentId!);
            return students;
        }


        [HttpGet("sort")]
        public List<Student> getAllOrdered()
        {
            students = students.OrderBy(x => x.Age).ToList();
            return students;
        }

       
        [HttpGet("byId")]
        public Student Get(int id)
        {
            return students.FirstOrDefault(s => s.Id.Equals(id));             
        }

        [HttpGet("byId/{id}")]
        public Student GetByIdInEndpoint(int id)
        {
            return students.FirstOrDefault(s => s.Id.Equals(id));
        }

        [HttpGet("filter/{name}/{age}")]
        public Student GetWithFilters(string name, int age)
        {
            return students.FirstOrDefault(s => s.Name.Equals(name) && s.Age.Equals(age));
        }

        [HttpGet("fromRouteWithId/{id}")]
        public Student GetByIdWithFromRoute([FromRoute] int id)
        {
            return students.FirstOrDefault(s => s.Id.Equals(id));
        }

        [HttpGet("fromHeader")]
        public Student GetByIdFromHeader([FromHeader] int id)
        {
            return students.FirstOrDefault(s => s.Id.Equals(id));
        }

        [HttpGet("fromQuery")]
        public Student GetByIdFromQuery([FromQuery] int id)
        {
            return students.FirstOrDefault(s => s.Id.Equals(id));
        }

        [HttpGet("fromQueryAsync")]
        public async Task<Student> GetByIdFromQueryAsync([FromQuery] int id)
        {
            return students.FirstOrDefault(s => s.Id.Equals(id));
        }


        [HttpPost("fromBody")]
        public IActionResult AddWithFromBody([FromBody] Student student)
        {
            students.Add(student);
            return Ok(students);
        }


        [HttpPost("fromForm")]
        public IActionResult AddWithFromForm([FromForm] Student student)
        {
            students.Add(student);
            return Ok(students);
        }

        [HttpPatch]
        public IActionResult Patch([FromRoute] int id, [FromBody] JsonPatchDocument<Student> student )
        {
            if(student != null)
            {
                var studentToUpdate = students.FirstOrDefault(s => s.Id.Equals(id));
                student.ApplyTo(studentToUpdate,(Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapterWithTest) ModelState);
            }

            if(!ModelState.IsValid)
            { 
                return  BadRequest(ModelState); 
            }

            return BadRequest("Object is null");

         //   return NotFound();
         //  return NoContent();
         //  return Forbid)();
        }



    }
}



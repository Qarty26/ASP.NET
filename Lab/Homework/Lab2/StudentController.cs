using Lab2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

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
            students.Remove(studentId);
            return students;
        }


        [HttpGet("sort")]
        public List<Student> getAllOrdered()
        {
            students = students.OrderBy(x => x.Age).ToList();
            return students;
        }

    }
}



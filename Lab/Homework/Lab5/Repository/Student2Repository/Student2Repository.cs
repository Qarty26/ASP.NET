using Lab3_2.Data;
using Lab3_2.Models;
using Lab3_2.Repository.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace Lab3_2.Repository.Student2Repository
{
    public class Student2Repository : GenericRepository<Student2>
    {
        public Student2Repository(Lab4Context lab4Context) : base(lab4Context) { }
        
        public List<Student2> OrderByAge(int age)
        {
            var studentsOrderedAsc1 = _table.OrderBy(x => x.Age);
            var studentsOrderedDesc1 = _table.OrderByDescending(x => x.Age);
            var studentsOrderedByMultiple = _table.OrderBy(x => x.Age).ThenBy(x => x.Id);

            //linq query sintax

            var studentsOrderedAsc2 = from s in _table
                                      orderby s.Age
                                      select s;

            var studentsOrderedDesc2 = from s in _table
                                      orderby s.Age descending
                                      select s;
            
            return studentsOrderedAsc1.ToList();
        }

        public List<Student2> GetAllWithInclude()
        {
            var result  = _table.Include(s => s.Models2)?.ThenInclude(x => x.Model1).ToList();

            //return result;
            return _table.Include(s => s.Models2).ToList();

            //model1 model1-a
            //Model2 model2-a
            //{..model1-a, {...model2-a}}
        }
        public List<dynamic> GetAllWithJoin()
        {
            var result = _lab4context.Models1.Join(_lab4context.Models2, model1 => model1.Id, model2 => model2.Model1Id,
                (model1,model2) => new { model1, model2}).Select(ob => ob.model1);

            //model1, model
            //{...model1-a, model2-a}, {...model1-b,...model2-b}

            return null;       
        }

        public Student2 Where(int age)
        {
            var result1 = _table.Where(x => x.Age < age).FirstOrDefault();
            var result2 = _table.FirstOrDefault(x => x.Age < age);

            var result3 = from s in _table
                          where s.Age < age
                          select s;

            return result1;
        }

        public void GroupBy()
        {
            var groupedStuds = _table.GroupBy(x => x.Id);
            var groupedStuds2 = from s in _table
                                group s by s.Age;

            foreach(var studentGroupedByAge in groupedStuds2)
            {
                Console.WriteLine("Student group age: " + studentGroupedByAge.Key);

                foreach(var s in studentGroupedByAge)
                {
                    Console.WriteLine("stundet name: " + s.LastName);
                }
            }
        }
    }
}

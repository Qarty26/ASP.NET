using Lab3_2.Models;
using Lab3_2.Repository.GenericRepository;

namespace Lab3_2.Repository.Student2Repository
{
    public interface IStudent2Repository : IGenericRepository<Student2>
    {
        List<Student2> OrderByAge(int age);
    }
}

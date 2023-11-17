using Lab3_2.Models.Base;
using Lab3_2.Models.One_to_Many;

namespace Lab3_2.Models
{
    public class Student2 : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }

        public ICollection<Model2> Models2 { get; set; }
    }
}

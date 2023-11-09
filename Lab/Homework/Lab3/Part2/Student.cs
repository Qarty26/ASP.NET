using Lab3_DB.Models.Base;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Lab3_DB.Models
{
    public class Student: BaseEntity
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}

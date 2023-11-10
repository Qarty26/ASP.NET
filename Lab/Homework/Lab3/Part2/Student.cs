using Lab3_2.Models.Base;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Lab3_2.Models
{
    public class Student : BaseEntity
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}
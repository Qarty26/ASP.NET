using Roads.Models.Base;

namespace Roads.Models
{
    public class Car : BaseEntity
    {
        public string? Make { get; set; }
        public string? Model { get; set; }   
        public int Year { get; set; }   
        public string? Color { get; set; }

    }
}

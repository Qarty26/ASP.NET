using Lab3_2.Models.Base;

namespace Lab3_2.Models.One_to_Many
{
    public class Model2 : BaseEntity
    {
        public string Name { get; set; }
        public Model1 Model1 { get; set; } 
        public Guid Model1Id { get; set; }
    }
}

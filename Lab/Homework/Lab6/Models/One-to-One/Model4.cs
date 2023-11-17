using Lab3_2.Models.Base;

namespace Lab3_2.Models.One_to_One
{
    public class Model4 : BaseEntity
    {
        public string? Name { get; set; }

        //relation

        public Model3 Model3 { get; set; }
        public Guid Model3Id { get; set; }  
    }
}

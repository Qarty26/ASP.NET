using Lab3_2.Models.Base;

namespace Lab3_2.Models.One_to_One
{
    public class Model3 : BaseEntity
    {
        public string? Name { get; set; }

        //relation
        public Model4 Model4 { get; set; }  
    }
}

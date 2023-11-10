using Lab3_2.Models.Base;

namespace Lab3_2.Models.Many_to_Many
{
    public class Model5 : BaseEntity
    {
        public string? Name { get; set; }

        //relation
        public ICollection<ModelsRelation> ModelsRelations { get; set; }
    }
}

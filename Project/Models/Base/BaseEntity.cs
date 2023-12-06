namespace Roads.Models.Base
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime? FirstCreated { get; set; } 
        public DateTime? LastModified { get; set; }
    }
}

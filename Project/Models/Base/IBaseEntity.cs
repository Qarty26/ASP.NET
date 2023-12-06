namespace Roads.Models.Base
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        DateTime? FirstCreated { get; set; }
        DateTime? LastModified { get; set; }
    }
}

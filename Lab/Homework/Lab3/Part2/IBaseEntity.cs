namespace Lab3_DB.Models.Base
{
    public class IBaseEntity
    {
        Guid Id { get; set; }
        DateTime? DateTime { get; set; }
        DateTime? LastModified { get; set; }
    }
}

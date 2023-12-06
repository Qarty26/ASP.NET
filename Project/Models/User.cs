using Roads.Models.Base;

namespace Roads.Models
{
    public class User : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public string NickName { get; set; } = Guid.NewGuid().ToString();
        public int Experience { get; set; } 
        public int Rank { get; set; }
        public string Status { get; set; } = "Regular";
        public List<Car>? Cars { get; set; }
        public List<Track>? Tracks { get; set; } 

    }
}

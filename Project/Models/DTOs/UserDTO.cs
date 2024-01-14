using Roads.Data.Enums;

namespace Roads.Models.DTOs
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; } = "Unknown user";
        public string? LastName { get; set; } = "";
        public string? UserName { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int Experience { get; set; } = 0;
        public int Rank { get; set; } = 0;
    }
}

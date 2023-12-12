﻿namespace Roads.Models.DTOs
{
    public class UserDTO
    {
        public string? FirstName { get; set; } = "Unknown user";
        public string? LastName { get; set; } = "";
        public DateTime? Birthday { get; set; }
        public string NickName { get; set; } = Guid.NewGuid().ToString();
        public int Experience { get; set; } = 0;
        public int Rank { get; set; } = 0;
        public string Status { get; set; } = "Regular";

    }
}

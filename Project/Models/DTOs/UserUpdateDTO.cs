﻿namespace Roads.Models.DTOs
{
    public class UserUpdateDTO
    {
        public Guid Id {  get; set; }
        public string UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
    }
}

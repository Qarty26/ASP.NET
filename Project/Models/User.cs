﻿using Roads.Data.Enums;
using Roads.Models.Base;
using Roads.Models.DTOs;
using Microsoft.AspNetCore.Identity;

namespace Roads.Models
{
    public class User : IdentityUser<Guid>
    {
        public string? FirstName { get; set; } = "Unknown user";
        public string? LastName { get; set; } = "";
        public DateTime? Birthday { get; set; }
        public int Experience { get; set; } = 0;
        public int Rank { get; set; } = 0;
        public Role Status { get; set; } = Role.Regular;


        public ICollection<Car>? Cars { get; set; } 
        public ICollection<UserTrackRelation>? UserTrackRelations { get; set;}

    }
}

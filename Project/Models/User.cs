﻿using Roads.Data.Enums;
using Roads.Models.Base;
using Roads.Models.DTOs;

namespace Roads.Models
{
    public class User : BaseEntity
    {
        public string? FirstName { get; set; } = "Unknown user";
        public string? LastName { get; set; } = "";
        public DateTime? Birthday { get; set; }
        public string NickName { get; set; } = Guid.NewGuid().ToString();
        public int Experience { get; set; } = 0;
        public int Rank { get; set; } = 0;
        public Role Status { get; set; } = Role.Regular;


        public ICollection<Car>? Cars { get; set; } 
        public ICollection<UserTrackRelation>? UserTrackRelations { get; set;}

    }
}

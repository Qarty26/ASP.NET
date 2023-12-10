﻿using Microsoft.EntityFrameworkCore;
using Roads.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Roads.Models
{
    public class Track : BaseEntity
    {
        public string? Name { get; set; }
        public string? StartPoint { get; set; }
        public string? EndPoint { get; set; }
        public int Xp { get; set; }
        public bool Confirmed { get; set; } = false;


        public ICollection<Hashtag> Hashtags { get; set; }
        public ICollection<TrackRelation> TrackRelations { get; set; }
    }
}

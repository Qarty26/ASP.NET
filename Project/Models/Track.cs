using Microsoft.EntityFrameworkCore;
using Roads.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Roads.Models
{
    public class Track : BaseEntity
    {
        public string? Name { get; set; } = "Unknown name";
        public int Xp { get; set; } = 0;
        public bool Confirmed { get; set; } = false;

        public Map? Map { get; set; }
        public ICollection<TrackHashtagRelation>? TrackHashtagRelations { get; set; }
        public ICollection<UserTrackCarRelation>? UserTrackCarRelations { get; set; }

    }
}

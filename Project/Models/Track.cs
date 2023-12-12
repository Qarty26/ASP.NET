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
        public string? StartPoint { get; set; }
        public string? EndPoint { get; set; }
        public int Xp { get; set; } = 0;
        public bool Confirmed { get; set; } = false;

        [JsonIgnore]
        public ICollection<Hashtag> Hashtags { get; set; }
        public ICollection<TrackRelation> TrackRelations { get; set; }
    }
}

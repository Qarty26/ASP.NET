using Roads.Models.Base;
using System.Text.Json.Serialization;

namespace Roads.Models
{
    public class Hashtag : BaseEntity
    {
        public string? Tag { get; set; }
        public int Xp { get; set; } = 0;

        public ICollection<TrackHashtagRelation>? TrackHashtagRelations { get; set; }
    }
}

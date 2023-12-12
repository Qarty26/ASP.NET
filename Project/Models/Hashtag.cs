using Roads.Models.Base;

namespace Roads.Models
{
    public class Hashtag : BaseEntity
    {
        public string? Tag { get; set; }

        public Track Track { get; set; }
        public Guid IdTrack { get; set; } 
    }
}

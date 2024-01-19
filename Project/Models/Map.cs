using Roads.Models.Base;

namespace Roads.Models
{
    public class Map : BaseEntity
    {
        public double StartLatitude { get; set; }
        public double StartLongitude { get; set; }
        public double EndLatitude { get; set; }
        public double EndLongitude { get; set; }

        public Guid IdTrack { get; set; }
        public Track Track { get; set; }
    }
}

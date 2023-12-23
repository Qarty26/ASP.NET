namespace Roads.Models
{
    public class TrackHashtagRelation
    {
        public Guid IdTrack { get; set; }
        public Track? Track { get; set;  } 
        public Guid IdHashtag { get; set; }
        public Hashtag? Hashtag { get; set; }

    }
}

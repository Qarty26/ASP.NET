namespace Roads.Models
{
    public class TrackCarRelation
    {
        public Guid IdTrack { get; set; }
        public Track? Track { get; set; }
        public Guid IdCar { get; set; }    
        public Car? Car { get; set; }   

        string? Time { get; set; } 
    }
}

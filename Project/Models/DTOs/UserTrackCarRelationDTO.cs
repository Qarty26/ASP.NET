namespace Roads.Models.DTOs
{
    public class UserTrackCarRelationDTO
    {
        public Guid? IdUser { get; set; }
        public Guid? IdTrack { get; set; }
        public Guid? IdCar { get; set; }
        public int Time { get; set; }
    }
}

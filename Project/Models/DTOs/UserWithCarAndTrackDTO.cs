namespace Roads.Models.DTOs
{
    public class UserWithCarAndTrackDTO
    {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public int Experience { get; set; } = 0;
        public int Rank { get; set; } = 0;

        public List<CarDTO> Cars { get; set; }
        public List<TrackWithCarDTO> Tracks { get; set; }

    }
}

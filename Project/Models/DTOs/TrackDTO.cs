namespace Roads.Models.DTOs
{
    public class TrackDTO
    {
        public Guid Id { get; set; }
        public string? Name { get; set; } = "Unknown name";
        public string? StartPoint { get; set; }
        public string? EndPoint { get; set; }
        public int Xp { get; set; } = 0;
        public bool Confirmed { get; set; } = false;
    }
}

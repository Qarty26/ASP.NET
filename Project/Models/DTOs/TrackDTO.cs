namespace Roads.Models.DTOs
{
    public class TrackDTO
    {
        public Guid Id { get; set; }
        public string? Name { get; set; } = "Unknown name";
        public int Xp { get; set; } = 0;
        public bool Confirmed { get; set; } = false;
        public Map? Map { get; set; }
    }
}

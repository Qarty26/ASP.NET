namespace Roads.Models.DTOs
{
    public class TrackCreateDTO
    {
        public string? Name { get; set; } = "Unknown name";
        public int Xp { get; set; } = 0;
        public bool Confirmed { get; set; } = false;
        public Map? Map { get; set; }
    }
}

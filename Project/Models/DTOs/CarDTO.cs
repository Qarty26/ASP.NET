namespace Roads.Models.DTOs
{
    public class CarDTO
    {
        public Guid Id { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public string? Color { get; set; }
    }
}

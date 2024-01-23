namespace Roads.Models.DTOs
{
    public class TrackWithTagsDTO
    {
        public Guid Id { get; set; }
        public string? Name { get; set; } = "Unknown name";
        public int Xp { get; set; } = 0;
        public bool Confirmed { get; set; } = false;
        public MapDTO? Map { get; set; }
        public List<TrackCarRelation> trackHashtagRelations { get; set; }
    }
}

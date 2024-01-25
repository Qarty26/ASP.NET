namespace Exam.Models.DTO
{
    public class EventWithPartDTO
    {
        public string? Name { get; set; }
        public ICollection<EventParticipantDTO>? EventParticipant { get; set; }
    }
}

using Exam.Models.Base;

namespace Exam.Models
{
    public class Event : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<EventParticipantRelation>? EventParticipantRelations { get; set; }
    }
}

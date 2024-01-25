using Exam.Models.Base;

namespace Exam.Models
{
    public class EventParticipantRelation : BaseEntity
    {
        public Guid? IdEvent { get; set; }
        public Event? Event { get; set; }
        public Guid? IdParticipant { get; set; }
        public Participant? Participant { get; set; }
    }
}

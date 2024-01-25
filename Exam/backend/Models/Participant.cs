using Exam.Data.Enums;
using Exam.Models.Base;

namespace Exam.Models
{
    public class Participant : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<EventParticipantRelation>? EventParticipantRelations { get; set; }
        public Role? Role { get; set; }
    }
}

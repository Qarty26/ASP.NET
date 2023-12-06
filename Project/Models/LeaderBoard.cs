using Roads.Models.Base;

namespace Roads.Models
{
    public class LeaderBoard : BaseEntity
    {
        public List<User>? AllTimeXp { get; set; }
        public List<User>? MostTracksCompleted { get; set; }
    }
}

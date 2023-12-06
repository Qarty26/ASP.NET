using Roads.Models.Base;
using System.Text;

namespace Roads.Models
{
    public class Track : BaseEntity
    {
        public string? Name { get; set; }
        public string? StartPoint { get; set; }  
        public string? EndPoint { get; set; }
        public List<string>? Hashtags { get; set; }  
        public int Xp { get; set; }
        public bool Confirmed { get; set; } = false;
    }
}

using Roads.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Roads.Models
{
    public class Car : BaseEntity
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public string? Color { get; set; }


        public User? User { get; set; }
        public Guid? IdUser { get; set; }
        public ICollection<TrackCarRelation>? TrackCarRelations { get; set; }

    }
}

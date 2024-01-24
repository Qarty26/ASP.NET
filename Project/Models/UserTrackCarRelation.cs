using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Roads.Models
{
    public class UserTrackCarRelation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid? IdUser { get; set; }    
        public User? User { get; set; }  
        public Guid? IdTrack { get; set; }   
        public Track? Track { get; set; }
        public Guid? IdCar { get; set; }
        public Car? Car { get; set; }
        public int Time { get; set; }


    }
}

﻿namespace Roads.Models
{
    public class TrackRelation
    {
        public Guid IdUser { get; set; }    
        public User User { get; set; }  
        public Guid IdTrack { get; set; }   
        public Track Track { get; set; }

    }
}

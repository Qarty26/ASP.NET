﻿using Roads.Models;
using Roads.Repository.GenericRepository;

namespace Roads.Repository.TrackRepository
{
    public interface ITrackRepository : IGenericRepository<Track>
    {
        List<Track> GetAllConfirmed();
        List<Track> GetAllPending();
        List<Track> OrderByHighestXp();
        List<Track> OrderByNewest();
        List<Track> GetAllTracksWithMap();
        List<Track> GetAllWithTags();
    }

}
using AutoMapper;
using Roads.Models;
using Roads.Models.DTOs;

namespace Roads.Services.TrackHashtagService
{
    public interface ITrackHashtagService
    {
        Task AddHashtagToTrack(Guid idTrack, Guid idHashtag);
    }
}
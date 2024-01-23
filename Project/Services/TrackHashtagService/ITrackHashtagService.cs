using AutoMapper;
using Roads.Models;

namespace Roads.Services.TrackHashtagService
{
    public interface ITrackHashtagService
    {
        Task AddHashtagToTrack(Guid idTrack, Guid idHashtag);
    }
}

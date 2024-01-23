using Roads.Models;

namespace Roads.Repository.TrackHashtagRepository
{
    public interface ITrackHashtagRepository
    {
        Task CreateAsync(TrackHashtagRelation relation);
    }
}

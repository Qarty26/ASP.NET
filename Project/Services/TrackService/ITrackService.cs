using Roads.Models;

namespace Roads.Services.TrackService
{
    public interface ITrackService
    {
        List<Track> GetAllConfirmed();
        List<Track> GetAllPending();
        List<Track> OrderByHighestXp();
        List<Track> OrderByNewest();
    }
}

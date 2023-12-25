using Roads.Models;
using Roads.Models.DTOs;

namespace Roads.Services.TrackService
{
    public interface ITrackService
    {
        TrackDTO GetTrackById(Guid id);
        List<TrackDTO> GetAllConfirmed();
        List<TrackDTO> GetAllPending();
        List<TrackDTO> OrderByHighestXp();
        List<TrackDTO> OrderByNewest();
        bool DeleteTrackById(Guid id);
    }
}

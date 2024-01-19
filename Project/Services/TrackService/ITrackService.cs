using Roads.Models;
using Roads.Models.DTOs;

namespace Roads.Services.TrackService
{
    public interface ITrackService
    {
        TrackDTO GetTrackById(Guid id);
        Task<List<TrackDTO>> GetAll();
        List<TrackDTO> GetAllWithMap();
        List<TrackDTO> GetAllConfirmed();
        List<TrackDTO> GetAllPending();
        List<TrackDTO> OrderByHighestXp();
        List<TrackDTO> OrderByNewest();
        void Update(TrackDTO track);
        Task CreateTrack(TrackCreateDTO track);
        bool DeleteTrackById(Guid id);
    }
}

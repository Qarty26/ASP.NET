using AutoMapper;
using Roads.Models;
using Roads.Models.DTOs;
using Roads.Repository.TrackRepository;

namespace Roads.Services.TrackService
{
    public class TrackService : ITrackService
    {
        public ITrackRepository _trackRepository;
        public IMapper _mapper;

        public TrackService(ITrackRepository trackRepository, IMapper mapper)
        {
            _trackRepository = trackRepository;
            _mapper = mapper;
        }

        public List<TrackDTO> GetAllConfirmed()
        {
            var allConfirmed = _trackRepository.GetAllConfirmed();
            return _mapper.Map<List<TrackDTO>>(allConfirmed);
        }

        public List<TrackDTO> GetAllPending()
        {
            var allPending = _trackRepository.GetAllPending();
            return _mapper.Map<List<TrackDTO>>(allPending);
        }

        public List<TrackDTO> OrderByHighestXp()
        {
            var highestXp = _trackRepository.OrderByHighestXp();
            return _mapper.Map<List<TrackDTO>>(highestXp);
        }

        public List<TrackDTO> OrderByNewest()
        {
            var newestTracks = _trackRepository.OrderByNewest();
            return _mapper.Map<List<TrackDTO>>(newestTracks);
        }
    }
}

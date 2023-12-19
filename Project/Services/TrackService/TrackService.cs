using AutoMapper;
using Roads.Models;
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

        public List<Track> GetAllConfirmed()
        {
            var allConfirmed = _trackRepository.GetAllConfirmed();
            return _mapper.Map<List<Track>>(allConfirmed);
        }

        public List<Track> GetAllPending()
        {
            var allPending = _trackRepository.GetAllPending();
            return _mapper.Map<List<Track>>(allPending);
        }

        public List<Track> OrderByHighestXp()
        {
            var highestXp = _trackRepository.OrderByHighestXp();
            return _mapper.Map<List<Track>>(highestXp);
        }

        public List<Track> OrderByNewest()
        {
            var newestTracks = _trackRepository.OrderByNewest();
            return _mapper.Map<List<Track>>(newestTracks);
        }
    }
}

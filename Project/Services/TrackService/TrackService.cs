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

        public TrackDTO GetTrackById(Guid id)
        {
            var track = _trackRepository.FindById(id);
            return _mapper.Map<TrackDTO>(track);
        }

        public async Task<List<TrackDTO>> GetAll()
        {
            var tracks = await _trackRepository.GetAllAsync();
            return _mapper.Map<List<TrackDTO>>(tracks);
        }


        public List<TrackDTO> GetAllWithMap()
        {
            var tracks = _trackRepository.GetAllTracksWithMap();
            return _mapper.Map<List<TrackDTO>>(tracks);
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

        public void Update(TrackDTO track)
        {
            var vtrack = _mapper.Map<Track>(track);
            _trackRepository.Update(vtrack);
        }

        public async Task CreateTrack(TrackCreateDTO track)
        {
            var vtrack = _mapper.Map<Track>(track);
            await _trackRepository.CreateAsync(vtrack);
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

        public bool DeleteTrackById(Guid id)
        {
            return _trackRepository.DeleteById(id);
        }
    }
}

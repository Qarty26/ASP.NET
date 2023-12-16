using AutoMapper;
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
    }
}

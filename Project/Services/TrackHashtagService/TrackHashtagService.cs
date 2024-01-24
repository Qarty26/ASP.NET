using AutoMapper;
using Roads.Models;
using Roads.Models.DTOs;
using Roads.Repository.HashtagRepository;
using Roads.Repository.TrackHashtagRepository;
using Roads.Repository.TrackRepository;

namespace Roads.Services.TrackHashtagService
{
    public class TrackHashtagService : ITrackHashtagService
    {
        public IMapper _mapper;
        public ITrackRepository _trackRepository;
        public IHashtagRepository _hashtagRepository;
        public ITrackHashtagRepository _trackHashtagRepository;

        public TrackHashtagService(IMapper mapper, ITrackRepository trackRepository, IHashtagRepository hashtagRepository, ITrackHashtagRepository trackHashtagRepository)
        {
            _mapper = mapper;
            _trackRepository = trackRepository;
            _hashtagRepository = hashtagRepository;
            _trackHashtagRepository = trackHashtagRepository;
        }

        public async Task AddHashtagToTrack(Guid idTrack, Guid idHashtag)
        {
            var track = await _trackRepository.FindByIdAsync(idTrack);
            if (track == null)
            {
                throw new Exception("Invalid track");
            }
            var tag = await _hashtagRepository.FindByIdAsync(idHashtag);
            if (tag == null)
            {
                throw new Exception("Invalid hashtag");
            }

            await _trackHashtagRepository.CreateAsync(_mapper.Map<TrackHashtagRelation>(new TrackHashtagRelationDTO()
            {
                IdTrack = idTrack,
                IdHashtag = idHashtag
            }));

            await _trackHashtagRepository.SaveAsync();

        }
    }
}
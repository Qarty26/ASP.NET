using AutoMapper;
using Roads.Models;
using Roads.Models.DTOs;
using Roads.Repository.HashtagRepository;

namespace Roads.Services.HashtagService
{
    public class HashtagService : IHashtagService
    {
        public IHashtagRepository _hashtagRepository;
        public IMapper _mapper;

        public HashtagService(IHashtagRepository hashtagRepository, IMapper mapper)
        {
            _hashtagRepository = hashtagRepository;
            _mapper = mapper;
        }

        public List<HashtagDTO> GetAllHashtags()
        {
            var allHashtags = _hashtagRepository.GetAll();
            return _mapper.Map<List<HashtagDTO>>(allHashtags);
        }

        public HashtagDTO GetHashtagById(Guid id)
        {
            var tag = _hashtagRepository.FindById(id);
            return _mapper.Map<HashtagDTO>(tag);
        }

        public async Task CreateHashtag(HashtagCreateDTO tag)
        {
            var hashtag = _mapper.Map<Hashtag>(tag);
            await _hashtagRepository.CreateAsync(hashtag);
        }

        public void UpdateHashtag(HashtagDTO tag)
        {
            var hashtag = _mapper.Map<Hashtag>(tag);
            _hashtagRepository.Update(hashtag);
        }

        public bool DeleteHashtagById(Guid id)
        {
            return _hashtagRepository.DeleteById(id);
        }


    }
}
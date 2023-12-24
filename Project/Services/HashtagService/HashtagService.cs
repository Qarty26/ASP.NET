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

        public List<HashtagDTO> GettAllHashtags()
        {
            var allHashtags = _hashtagRepository.GetAll();
            return _mapper.Map<List<HashtagDTO>>(allHashtags);
        }

        public bool DeleteHashtagById(Guid id)
        {
            return _hashtagRepository.DeleteById(id);
        }


    }
}
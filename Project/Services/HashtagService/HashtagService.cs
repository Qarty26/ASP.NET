using AutoMapper;
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


    }
}
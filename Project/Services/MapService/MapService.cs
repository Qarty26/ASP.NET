using AutoMapper;
using Roads.Repository.MapRepository;

namespace Roads.Services.MapService
{
    public class MapService : IMapService
    {
        public IMapRepository _mapRepository;
        public IMapper _mapper;

        public MapService(IMapper mapper, IMapRepository mapRepository)
        {
            _mapper = mapper;
            _mapRepository = mapRepository;
        }

    }
}

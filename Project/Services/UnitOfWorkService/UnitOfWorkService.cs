using Roads.Repository.CarRepository;
using Roads.Repository.HashtagRepository;
using Roads.Repository.MapRepository;
using Roads.Repository.TrackHashtagRepository;
using Roads.Repository.TrackRepository;
using Roads.Repository.UserTrackCarRelationRepository;

namespace Roads.Services.UnitOfWorkService
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        public ITrackRepository _trackRepository;
        public ICarRepository _carRepository;
        public IHashtagRepository _hashtagRepository;
        public IMapRepository _mapRepository;
        public ITrackHashtagRepository _trackHashtagRepository;
        public IUserTrackCarRelationRepository _userTrackCarRelationRepository;

        public UnitOfWorkService (ITrackRepository trackRepository,
                                    ICarRepository carRepository,
                                    IHashtagRepository hashtagRepository,
                                    IMapRepository mapRepository,
                                    ITrackHashtagRepository trackHashtagRepository,
                                    IUserTrackCarRelationRepository userTrackCarRelationRepository)
        {
            _trackRepository = trackRepository;
            _carRepository = carRepository;
            _hashtagRepository = hashtagRepository;
            _mapRepository = mapRepository;
            _trackHashtagRepository = trackHashtagRepository;
            _userTrackCarRelationRepository = userTrackCarRelationRepository;
        }

        public async Task SaveAllAsync()
        {
            await _trackRepository.SaveAsync();
            await _trackHashtagRepository.SaveAsync();
            await _userTrackCarRelationRepository.SaveAsync();
            await _hashtagRepository.SaveAsync();
            await _userTrackCarRelationRepository.SaveAsync();
            await _carRepository.SaveAsync();
        }

        public void SaveAll()
        {
            _carRepository.Save();
            _trackRepository.Save();
            _hashtagRepository.Save();
            _mapRepository.Save();
        }
    }
}

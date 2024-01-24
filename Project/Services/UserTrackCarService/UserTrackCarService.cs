using AutoMapper;
using Roads.Models.DTOs;
using Roads.Models;
using Roads.Repository.CarRepository;
using Roads.Repository.TrackRepository;
using Roads.Repository.UserRepository;
using Roads.Repository.UserTrackCarRelationRepository;

namespace Roads.Services.UserTrackCarService
{
    public class UserTrackCarService : IUserTrackCarService
    {
        public IMapper _mapper;
        public IUserRepository _userRepository;
        public ITrackRepository _trackRepository;
        public ICarRepository _carRepository;
        public IUserTrackCarRelationRepository _userTrackCarRelationRepository;
    
        public UserTrackCarService(IMapper mapper, IUserRepository userRepository, ITrackRepository trackRepository, ICarRepository carRepository, IUserTrackCarRelationRepository userTrackCarRelationRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _trackRepository = trackRepository;
            _carRepository = carRepository;
            _userTrackCarRelationRepository = userTrackCarRelationRepository;
        }

        public async Task AddTrackWithCarToUser(Guid idTrack, Guid idCar, Guid idUser)
        {
            var track = await _trackRepository.FindByIdAsync(idTrack);
            if (track == null)
            {
                throw new Exception("Invalid track");
            }

            var user = await _userRepository.GetUserById(idUser);
            if (user == null)
            {
                throw new Exception("Invalid user");
            }

            var car = await _carRepository.FindByIdAsync(idCar);
            if (car == null)
            {
                throw new Exception("Invalid car");
            }

            if(car.IdUser != idUser)
            {
                throw new Exception("Car doesn't belong to user");
            }

            await _userTrackCarRelationRepository.CreateAsync(_mapper.Map<UserTrackCarRelation>(new UserTrackCarRelationDTO()
            {
                IdUser = idUser,
                IdTrack = idTrack,
                IdCar = idCar
            }));

            await _userTrackCarRelationRepository.SaveAsync();

        }
    }
}

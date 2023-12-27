using AutoMapper;
using Roads.Models;
using Roads.Models.DTOs;
using Roads.Repository.CarRepository;
using Roads.Repository.UserRepository;

namespace Roads.Services.UserCarService
{
    public class UserCarService : IUserCarService
    {
        public IUserRepository _userRepository;
        public ICarRepository _carRepository;
        public IMapper _mapper;
        
        public UserCarService(IMapper mapper, IUserRepository userRepository, ICarRepository carRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
            _carRepository = carRepository;
        }

        public async Task<User> AddCarToUser(CarDTO carDTO, Guid id)
        {
            var user = await _userRepository.GetUserById(id);
            var car = _mapper.Map<Car>(carDTO);
            user.Cars.Add(car);
            return user;
        }
    }
}

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

        public async Task AddCarToUser(Guid idCar, Guid idUser)
        {
            var user = await _userRepository.GetUserById(idUser);
            if (user == null)
            {
                throw new Exception("User does not exist");
            }
            var car = await _carRepository.FindByIdAsync(idCar);
            
            car.IdUser = idUser;
            _carRepository.Update(car);
        }

        public async Task CreateCarToUser(CarDTO car, Guid idUser)
        {
            var user = await _userRepository.GetUserById(idUser);
            if (user == null)
            {
                throw new Exception("User does not exist");
            }
            var _car = _mapper.Map<Car>(car);
            await _carRepository.CreateAsync(_car);
            _car.IdUser = idUser;

            _carRepository.Update(_car);
        }
    }
}

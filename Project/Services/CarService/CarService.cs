using AutoMapper;
using Roads.Models;
using Roads.Models.DTOs;
using Roads.Repository.CarRepository;

namespace Roads.Services.CarService
{
    public class CarService : ICarService
    {
        public ICarRepository _carRepository;
        public IMapper _mapper;

        public CarService (ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public List<CarDTO> YearsBetween(int startYear, int endYear)
        {
            var years = _carRepository.YearsBetween(startYear, endYear);
            return _mapper.Map<List<CarDTO>>(years);
        }

        public CarDTO GetCarById(Guid id)
        {
            var car = _carRepository.FindById(id);
            return _mapper.Map<CarDTO>(car);
        }

        public async Task<List<CarDTO>> GetAllCars()
        {
            var cars = await _carRepository.GetAllAsync();
            return _mapper.Map<List<CarDTO>>(cars);
        }

        public async Task CreateCar(CarCreateDTO car)
        {
            var vcar = _mapper.Map<Car>(car);
            await _carRepository.CreateAsync(vcar);
        }

        public void UpdateCar(CarDTO car)
        {
            var vcar = _mapper.Map<Car>(car);
            _carRepository.Update(vcar);
        }

        public bool DeleteCarById(Guid id)
        {
            return _carRepository.DeleteById(id);
        }
    }
}

using AutoMapper;
using Roads.Models;
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

        public List<Car> YearsBetween(int startYear, int endYear)
        {
            var years = _carRepository.YearsBetween(startYear, endYear);
            return _mapper.Map<List<Car>>(years);
        }
    }
}

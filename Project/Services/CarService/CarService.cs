using AutoMapper;
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
    }
}

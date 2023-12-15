using Roads.Data;
using Roads.Models;
using Roads.Repository.GenericRepository;

namespace Roads.Repository.CarRepository
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        public CarRepository(RoadsContext roadsContext) : base(roadsContext)
        {
        }
    }
}

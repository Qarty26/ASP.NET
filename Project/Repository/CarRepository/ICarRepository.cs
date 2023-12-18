using Roads.Models;
using Roads.Repository.GenericRepository;

namespace Roads.Repository.CarRepository
{
    public interface ICarRepository : IGenericRepository<Car>
    {
        List<Car> YearsBetween(int startYear, int endYear);
    }
}

using Microsoft.EntityFrameworkCore;
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

        public List<Car> YearsBetween(int startYear, int endYear)
        {
            return _table.AsNoTracking().Where(x => x.Year >= startYear && x.Year <= endYear).ToList();
        }

    }
}

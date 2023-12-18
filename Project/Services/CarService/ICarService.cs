using Roads.Models;

namespace Roads.Services.CarService
{
    public interface ICarService
    {
        List<Car> YearsBetween(int startYear, int endYear);
    }
}

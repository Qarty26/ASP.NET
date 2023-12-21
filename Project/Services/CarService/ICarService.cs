using Roads.Models;
using Roads.Models.DTOs;

namespace Roads.Services.CarService
{
    public interface ICarService
    {
        List<Car> YearsBetween(int startYear, int endYear);
    }
}

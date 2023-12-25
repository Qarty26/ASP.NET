using Roads.Models;
using Roads.Models.DTOs;

namespace Roads.Services.CarService
{
    public interface ICarService
    {
        List<CarDTO> YearsBetween(int startYear, int endYear);
        CarDTO GetCarById(Guid id);
        bool DeleteCarById(Guid id);

    }
}

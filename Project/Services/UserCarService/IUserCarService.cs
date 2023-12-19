using Roads.Models.DTOs;
using Roads.Models;

namespace Roads.Services.UserCarService
{
    public interface IUserCarService
    {
        User AddCarToUser(CarDTO carDTO, Guid id);
    }
}

using Roads.Models.DTOs;
using Roads.Models;

namespace Roads.Services.UserCarService
{
    public interface IUserCarService
    {
        Task AddCarToUser(Guid idCar, Guid idUser);
        Task CreateCarToUser(CarDTO car, Guid idUser);
    }
}

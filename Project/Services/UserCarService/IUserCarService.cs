using Roads.Models.DTOs;
using Roads.Models;

namespace Roads.Services.UserCarService
{
    public interface IUserCarService
    {
        Task<User> AddCarToUser(CarDTO carDTO, Guid id);
    }
}
